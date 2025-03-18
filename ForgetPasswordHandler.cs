using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace DBS25P156
{
    public class ForgetPasswordHandler
    {
        public bool UserCheck(string username)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE username = '{username}' OR email ='{username}'";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query));
            return count > 0;
        }



        public bool UpdatePassword(string password)
        {
            //string hashed_password = BCrypt.Net.BCrypt.HashPassword(password);
            string query = $"UPDATE users SET password_hash = '{password}' WHERE username = '{UserSession.UserLoginUserName_Email}' OR email = '{UserSession.UserLoginUserName_Email}'";
            return DatabaseHelper.Instance.ExecuteQuery(query) > 0;
        }
    }
}
