using Core.Models;
using Core.Services;
using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.ViewModels
{
    public class MainViewModel 
        : MvxViewModel
    {
        private ObservableCollection<Contact> _contacts;
        private IPopupService _popupService;

        public ObservableCollection<Contact> Contacts
        { 
            get { return _contacts; }
            set {
                _contacts = value;
                RaisePropertyChanged(() => Contacts);
               
                // SetProperty - ustawia wartoœæ i wywo³uje RaisePropertyChanged
               // SetProperty (ref _contacts, value);
            }
        }

        private IMvxCommand addContact;
        public IMvxCommand AddContact
        {
            get
            {
                if(addContact == null)
                {
                    addContact = new MvxCommand(() =>
                    {
                        ShowViewModel<AddContactViewModel>();
                    });
                }

                return addContact;
            }
        }

        private IMvxCommand deleteContact;
        public IMvxCommand DeleteContact
        {
            get
            {
                if (deleteContact == null)
                {
                    deleteContact = new MvxCommand<Contact>((contact) =>
                    {
                        _popupService.Show("Delete Contact", string.Format("Are you sure you want to delete {0}?", contact.Name),
                                            "Yes", () => Contacts.Remove(contact), 
                                            "No", delegate { });
                    });
                }

                return deleteContact;
            }
        }

        public MainViewModel(IPopupService popupService)
        {
            _popupService = popupService;

            Initialize();
        }

        public void Initialize()
        {
            Contacts = new ObservableCollection<Contact>();

            for (int i = 1; i <= 20; i++)
            {
                Contacts.Add(new Contact("My " + i, "my_email@gmail.com", "530529985"));
            }

            //_contacts = contacts;
        }
    }
}
