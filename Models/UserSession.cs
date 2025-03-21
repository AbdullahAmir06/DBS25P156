using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156.Models
{
    public static class UserSession
    {
        public static int UserLoginRoleID { get; set; }
        public static string UserLoginUserName { get; set; }

        public static string UserLoginEmail { get; set; }

        public static int SelectedEditionID { get; private set; } = -1;

        public static void SelectedEdition(int editionID)
        {
            
            SelectedEditionID = editionID;
        }
    }


}
