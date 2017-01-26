using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using Core.Models;
using MvvmCross.Plugins.Messenger;
using Core.Messages;
using DataAccess.Entities;

namespace Core.ViewModels
{
    public class AddContactViewModel : MvxViewModel
    {

        

        public AddContactViewModel(IMvxMessenger messenger)
        {
            _messenger = messenger;
        }


        #region Properties
        private IMvxMessenger _messenger;

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetProperty (ref _name, value);
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                SetProperty(ref _email, value);
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                SetProperty(ref _phoneNumber, value);
            }
        }

        #endregion

        private IMvxCommand addContact;
        public IMvxCommand AddContact
        {
            get
            {
                if (addContact == null)
                {
                    addContact = new MvxCommand(() =>
                    {
                        var newContact = new ContactEntity(Name, Email, PhoneNumber);
                        _messenger.Publish(new ContactMessage(this, newContact));

                        Close(this);
                    });
                }

                return addContact;
            }
        }
    }
}
