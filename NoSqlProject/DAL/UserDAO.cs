using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.ObjectModel;
using System.Collections;

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
        public List<User> getMatchedUser(string email, string password)
        {
            return collectionUsers.Find(x => x.Email == email && x.Password == password).ToList<User>();
        }


    }
}
