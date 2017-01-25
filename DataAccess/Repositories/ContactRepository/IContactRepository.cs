using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories.ContactRepository
{
    public interface IContactRepository
    {
        Task Add(ContactEntity contact);
        Task Delete(int id);
        Task<List<ContactEntity>> GetAll();
    }
}
