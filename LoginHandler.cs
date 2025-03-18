using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156
{
    public class LoginHandler
    {
        public bool ValidateUser(string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE (username = '{username}' OR email = '{username}') AND password_hash = '{password}'";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query));
            return count > 0;
        }

        public int GetRoleID(string username)
        {
            string query = $"SELECT role_id FROM users WHERE username = '{username}' OR email = '{username}'";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query));
        }
    }
}
