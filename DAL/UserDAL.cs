using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;
using BCrypt.Net;

namespace DBS25P156.DAL
{
    public class UserDAL
    {
        public bool CreateUser(User user)
        {
            user.Password = HashedPassword(user.Password);
            string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@username, @email, @password, @roleId)";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { user.Username, user.Email, user.Password, user.RoleId }) > 0;
        }

        public int RoleIDAssign(string role)
        {
            string query = "SELECT role_id FROM roles WHERE role_name = @role";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { role }));
        }

        public User GetUserByEmailOrUsername(string identifier)
        {
            string query = "SELECT * FROM users WHERE username = @identifier OR email = @identifier";
            var row = DatabaseHelper.Instance.GetRow(query, new object[] { identifier });
            if (row.Count > 0)
            {
                return new User(
                    Convert.ToInt32(row["user_id"]),
                    row["username"].ToString(),
                    row["email"].ToString(),
                    row["password_hash"].ToString(),
                    Convert.ToInt32(row["role_id"])
                );
            }
            return null;
        }

        public bool ValidateUser(string identifier, string password)
        {
            User user = GetUserByEmailOrUsername(identifier);
            return user != null && user.Password == password;
        }
        public bool UserExists(string identifier)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @identifier OR email = @identifier";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { identifier }));
            return count > 0;
        }

        public int GetRoleID(string identifier)
        {
            string query = "SELECT role_id FROM users WHERE username = @identifier OR email = @identifier";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { identifier }));
        }


        public bool UpdatePassword(string newPassword, string identifier)
        {
            newPassword = HashedPassword(newPassword);
            string query = "UPDATE users SET password_hash = @password WHERE username = @identifier OR email = @identifier";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newPassword, identifier }) > 0;
        }

        public List<string> GetUsers()
        {
            string query = "SELECT username from users where username != @Username";
            return DatabaseHelper.Instance.GetColumn(query,new object[] {UserSession.UserLoginUserName}).Select(e => e?.ToString() ?? "").ToList();
        }

        public int GetUserId(string identifier)
        {
            string query = "SELECT user_id from users where username =@identifier";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { identifier }));
        }
           
        public  static string HashedPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static bool VerifyPassword(string enteredPassword,string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
        }
    }
}
