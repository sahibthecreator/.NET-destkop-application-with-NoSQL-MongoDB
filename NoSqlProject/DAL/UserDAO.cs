using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.ObjectModel;
using System.Collections;
using MongoDB.Bson.IO;

namespace DAL
{
    public class UserDAO : DAO
    {
        IMongoCollection<User> collectionUsers;
        public UserDAO()
        {
            collectionUsers = Db.GetCollection<User>("Users");
        }
        public List<User> GetAllUsers()
        {
            return collectionUsers.AsQueryable().ToList<User>();
        }
      
        public List<User> GetUserByEmail(string email)
        {
            return collectionUsers.Find(x => x.Email == email).ToList<User>();
        }

        public User GetUserById(string id)
        {
            return collectionUsers.FindAsync(x => x.Id == id).Result.Single();
        }

        public void AddUser(User user)
        {
            collectionUsers.InsertOne(user);
        }

    }
}
