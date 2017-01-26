using ContactList.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactList.Web.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ContactEntity> Contacts { get; set; }

        public DatabaseContext() : base()
        {

        }
    }
}