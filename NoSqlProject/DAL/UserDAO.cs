using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class UserDAO : DAO
    {
        IMongoDatabase userDb;
        IMongoCollection<User> collectionUsers;
        public UserDAO()
        {
            userDb = client.GetDatabase("Db");
            collectionUsers = userDb.GetCollection<User>("Users");
        }
        public List<User> getAllUsers()
        {
            return collectionUsers.AsQueryable().ToList<User>();
        }
    }
}
