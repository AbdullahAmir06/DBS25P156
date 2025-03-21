using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.DAL;
using DBS25P156.Models;

namespace DBS25P156.BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        public bool RegisterUser(string username, string email, string password, string roll)
        {

            if (userDAL.UserExists(username) || userDAL.UserExists(email))
            {
                return false;
            }

            User user = new User { Username = username, Email = email, Password = password, RoleId = userDAL.RoleIDAssign(roll) };
            return userDAL.CreateUser(user);
        }

        public User AuthenticateUser(string identifier, string password)
        {
            User user = userDAL.GetUserByEmailOrUsername(identifier);
            return (user != null && user.Password == password) ? user : null;
        }

        public bool UpdatePassword(string newPassword, string identifier)
        {
            if(!userDAL.UserExists(identifier))
            {
                return false;
            }
            return userDAL.UpdatePassword(newPassword, identifier);
        }

        public List<string> GetUsers()
        {
            return userDAL.GetUsers();  
        }
    }
}
