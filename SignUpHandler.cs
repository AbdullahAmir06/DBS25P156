using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156
{
    public class SignUpHandler
    {
        public bool AddUser(string username, string password, string email, string role)
        {
            string query = $"INSERT INTO users (username, password_hash, email, role_id) VALUES ('{username}', '{password}', '{email}', (SELECT role_id FROM roles WHERE role_name = '{role}'))";
            return DatabaseHelper.Instance.ExecuteQuery(query)>0;
        }

        public bool UserCheck(string username, string email)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE username = '{username}' OR email = '{email}'";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query));
            return count > 0;
        }
    }
}
