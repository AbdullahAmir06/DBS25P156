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
                //string fromEntityType        // sponsor fix          // id fix by sponsorid1 , string fromEntityUserName
        public bool AddSponsor(string name, string contact, int amount, string toEntityUserName, string toEntityType,int eventId)
        {
            Sponsor_Vendor sponsor_Vendor = new Sponsor_Vendor(name,contact);
            Sponsor_VendorDAL.AddSponsor(sponsor_Vendor);

            int typeID = Sponsor_VendorDAL.GetTypeId("Sponsorship");
            int fromEntityId = Sponsor_VendorDAL.GetSponsorId(name,contact);
            int toEntityId  = Sponsor_VendorDAL.GetEntityID(toEntityType,toEntityUserName);

            Sponsor_Vendor Sponsor_Vendor = new Sponsor_Vendor(name, contact, typeID, amount, fromEntityId, toEntityId, "Sponsor", toEntityType,eventId);
            //Sponsor_Vendor.fromEntityType = "Sponsor";

            return Sponsor_VendorDAL.UpdateToFinances(Sponsor_Vendor);

        }

        public bool AddVendor(string name, string contact, string service)
        {
            Sponsor_Vendor sponsor_Vendor = new Sponsor_Vendor(name, contact, service);
            return Sponsor_VendorDAL.AddVendor(sponsor_Vendor);
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
