using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class UserDAO : Base
    {
        IMongoDatabase userDb;
        IMongoCollection<User> users;
        public UserDAO()
        {
            userDb = client.GetDatabase("Db");
            users = userDb.GetCollection<User>("Users");
        }
    }
}
