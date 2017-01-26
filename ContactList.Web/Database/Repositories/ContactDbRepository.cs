using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactList.Web.Database.Entities;

namespace ContactList.Web.Database.Repositories
{
    public class ContactDbRepository : IContactRepository
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        public void Add(ContactEntity contact)
        {
            _dbContext.Contacts.Add(contact);
        }

        public void Delete(int id)
        {
            _dbContext.Contacts.Remove(_dbContext.Contacts.FirstOrDefault(x => x.Id == id));
        }

        public List<ContactEntity> GetAll()
        {
           return _dbContext.Contacts.ToList();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}