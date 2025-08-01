﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class Sponsor_VendorDAL
    {

        public bool AddVendor(Sponsor_Vendor sponsor_Vendor)
        {
            string query = "INSERT INTO vendors (vendor_name,contact,service_type) VALUES (@name,@contact,@servicetype)";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { sponsor_Vendor.Name, sponsor_Vendor.contact, sponsor_Vendor.servicetype }) > 0;
        }
        public bool AddSponsor(Sponsor_Vendor sponsor_Vendor)
        {
            string query = "INSERT INTO sponsors (sponsor_name, contact) VALUES (@Name,@contact)";


            int rowAffect = DatabaseHelper.Instance.ExecuteQuery(query, new object[] { sponsor_Vendor.Name, sponsor_Vendor.contact });

            return rowAffect > 0;
        }


        public bool UpdateToFinances(Sponsor_Vendor sponsor_Vendor)
        {
            string financeQuery = "INSERT INTO finances (itec_id,event_id,type_id,amount,from_entity_type,from_entity_id,to_entity_type,to_entity_id) VALUES (@SelectedEditionID,@eventId,@typeId,@amount,@fromEntityType,@fromEntityId,@toEntityType,@toEntityId) ";
            int row2Affect = DatabaseHelper.Instance.ExecuteQuery(financeQuery, new object[] { UserSession.SelectedEditionID, sponsor_Vendor.eventId,sponsor_Vendor.typeId, sponsor_Vendor.amount, sponsor_Vendor.fromEntityType, sponsor_Vendor.fromEntityId, sponsor_Vendor.toEntityType, sponsor_Vendor.toEntityId });
            return row2Affect > 0;
        }

        public List<string> GetCommitteeNames()
        {
            string query = "SELECT distinct committee_name from committees right join itec_events e on e.committee_id=committees.committee_id where e.itec_id =@SelectedEditionID";
            return DatabaseHelper.Instance.GetColumn(query, new object[] { UserSession.SelectedEditionID }).Select(e => e?.ToString() ?? "").ToList();
        }

        public int GetCommiteeId(string committeeName)
        {
            string query = "select committee_id from committees where committee_name = @committeeName";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { committeeName }));
        }      
        
        //public List <string> GetEventName



        public List<string> GetVendorNames()
        {
            string query = "SELECT vendor_name from vendors";
            return DatabaseHelper.Instance.GetColumn(query).Select(e => e?.ToString() ?? "").ToList();
        }

        public int GetTypeId(string type)
        {
            string query = "SELECT lookup_id from lookup where value =@type";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { type }));
        }

        public int GetEntityID(string entityCategory, string entityName)
        {
            if (entityCategory == "User")
            {
                string query = "SELECT user_id from users where username = @entityName";
                return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { entityName }));
            }
            else if (entityCategory == "Vendor")
            {
                string query = "SELECT vendor_id from vendors where vendor_name = @entityName";
                return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { entityName }));
            }
            else if (entityCategory == "Committee")
            {
                string query = "SELECT committee_id from committees where committee_name = @entityName AND itec_id = @SelectedEditionId";
                return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { entityName, UserSession.SelectedEditionID }));
            }
            return 0;
        }

        public int GetFromPersonId(string personName)
        {
            string query = "SELECT sponsor_id from sponsors where sponsor_name =@personName";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { personName }));
        }

        public int GetSponsorId(string sponsorName, string sponsorContact)
        {
            string query = "SELECT sponsor_id from sponsors where sponsor_name =@sponsorName and contact =@sponsorContact";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { sponsorName, sponsorContact }));
        }



    }
}
