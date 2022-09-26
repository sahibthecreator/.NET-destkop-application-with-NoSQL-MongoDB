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
        public List<User> getAllUsers()
        {
           return userDAO.getAllUsers();
        }
        public List<User> getMatchedUser(string username, string password)
        {
            return userDAO.getMatchedUser(username, password);
        }

    }
}
