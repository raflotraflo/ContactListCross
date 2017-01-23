using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Plugins.Messenger;
using Core.Models;

namespace Core.Messages
{
    public class ContactMessage : MvxMessage
    {
        public Contact Contact { get; set; }

        public ContactMessage(Object sender, Contact contact) : base(sender)
        {
            Contact = contact;
        }
    }
}
