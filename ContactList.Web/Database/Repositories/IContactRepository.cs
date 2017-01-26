using ContactList.Web.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Web.Database.Repositories
{
    public interface IContactRepository
    {
        void Add(ContactEntity contact);
        void Delete(int id);
        List<ContactEntity> GetAll();
        void Save();
    }
}
