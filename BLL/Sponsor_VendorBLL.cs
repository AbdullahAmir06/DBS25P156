using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.DAL;
using DBS25P156.Models;

namespace DBS25P156.BLL
{
    public class Sponsor_VendorBLL
    {
        Sponsor_VendorDAL Sponsor_VendorDAL = new Sponsor_VendorDAL();

        public bool AddSponsor(string name, string contact, int amount, string fromEntityType, string toEntityUserName, string toEntityType, string fromEntityUserName)
        {

            int typeID = Sponsor_VendorDAL.GetTypeId("Sponsorship");
            int fromEntityId = Sponsor_VendorDAL.GetEntityID(fromEntityUserName,fromEntityType);
            int toEntityId  = Sponsor_VendorDAL.GetEntityID(toEntityType,fromEntityUserName);

            Sponsor_Vendor Sponsor_Vendor = new Sponsor_Vendor(name, contact, typeID, amount, fromEntityId, toEntityId, fromEntityType, toEntityType);
            return Sponsor_VendorDAL.AddSponsor(Sponsor_Vendor);

        }

        public List<string> GetCommitteeNames()
        {
            return Sponsor_VendorDAL.GetCommitteeNames();
        }

        public List<string> GetUserName()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetUsers().ToList();
        }

        public List<string> GetVendorName()
        {
            return Sponsor_VendorDAL.GetVendorNames();
        }


    }
}
