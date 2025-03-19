using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }


        public User(int id, string username, string email, string pass, int roleID)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = pass;
            RoleId = roleID;
        }

        public User(string username, string pass)
        {
            Username = username;
            Password = pass;
        }
        public User() { }
    }


}
