using ContactList.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactList.Web.Models
{
    public class ContactsResponse : BaseResponse
    {
        public List<ContactEntity> Contacts { get; set; }
    }
}