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

        public DatabaseContext() : base("Server=tcp:contactlist.database.windows.net,1433;Initial Catalog=ContactListDb;Persist Security Info=False;User ID=contactlist;Password=Krzysztof90;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }
    }
}