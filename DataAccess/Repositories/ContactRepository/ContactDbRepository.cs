using DataAccess.Repositories.Base;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Repositories.ContactRepository
{
    public class ContactDbRepository : BaseDbRepository, IContactRepository
    {
        public ContactDbRepository(SQLiteConnection connection) : base(connection)
        {

        }

        public Task Add(ContactEntity contact)
        {
            return Task.Run(() =>
            {
                lock (_databaseLock)
                {
                    _dbConnection.Insert(contact);
                }
            });
        }

        public Task Delete(int id)
        {
            return Task.Run(() =>
            {
                lock (_databaseLock)
                {
                    _dbConnection.Delete<ContactEntity>(id);
                }
            });
        }

        public Task<List<ContactEntity>> GetAll()
        {
            return Task.Run(() =>
            {
                lock (_databaseLock)
                {
                   return _dbConnection.Table<ContactEntity>().ToList();
                }
            });
        }
    }
}
