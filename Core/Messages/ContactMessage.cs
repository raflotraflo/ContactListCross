using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using Core.Models;
using DataAccess.Entities;

namespace Core.Messages
{
    public class ContactMessage : MvxMessage
    {
        public ContactEntity Contact { get; set; }

        public ContactMessage(Object sender, ContactEntity contact) : base(sender)
        {
            Contact = contact;
        }
    }
}
