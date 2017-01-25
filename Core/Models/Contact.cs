using Core.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Entities;


namespace Core.Models
{
    public class Contact : ContactEntity
    {

        public Contact(string name, string email, string phoneNumber): base(name, email, phoneNumber)
        {
        }

        private IMvxCommand _emailContact;
        public IMvxCommand EmailContact
        {
            get
            {
                if (_emailContact == null)
                {
                    _emailContact = new MvxCommand(() =>
                    {
                        Mvx.Resolve<IEmailService>().OpenClient(Email);
                    });
                }

                return _emailContact;
            }
        }

        private IMvxCommand _callContact;
        public IMvxCommand CallContact
        {
            get
            {
                if (_callContact == null)
                {
                    _callContact = new MvxCommand(() =>
                    {
                        Mvx.Resolve<ICallerService>().Call(PhoneNumber);
                    });
                }

                return _callContact;
            }
        }
    }
}
