using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class UserService
    {
        UserDAO userDAO;
        public UserService()
        {
            userDAO= new UserDAO(); 
        }

        public List<User> GetAllUsers()
        {
           return userDAO.GetAllUsers();
        }

        public List<User> GetUserByEmail(string email)
        {
            return userDAO.GetUserByEmail(email);
        }
        
        public User GetUserById(string id)
        {
            return userDAO.GetUserById(id);
        }

        public void AddUser(User user)
        {
            userDAO.AddUser(user);
        }

    }
}
