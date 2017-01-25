using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Base
{
    public class BaseDbRepository
    {
        protected static object _databaseLock = new object();
        protected SQLiteConnection _dbConnection { get; set; }

        public BaseDbRepository(SQLiteConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
    }
}
