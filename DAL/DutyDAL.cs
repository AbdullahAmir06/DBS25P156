using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;
using Org.BouncyCastle.Asn1.Mozilla;

namespace DBS25P156.DAL
{
    public class DutyDAL
    {

        public CommitteeDAL CommitteeDAL = new CommitteeDAL();

        public int committeeID;

        public string description { get; set; }
        public string status { get; set; }
        public DateTime date { get; set; }

        public DutyDAL(string description, DateTime date, string status)
        {
            this.description = description;
            this.date = date;
            this.status = status;
        }

        public List<string> GetCommitteeNames(string name)
        {
            return CommitteeDAL.GetCommitteeNameOfSpecificUser(name);
        }

        public DutyDAL GetDutyDetails(string committeeName)
        {
            int committeeId = CommitteeDAL.GetCommitteeId(committeeName);
            string query = "SELECT task_description,deadline,status_id from duties where assigned_to =@UserLoginUserName and committee_id =@committeeId";

            var row = DatabaseHelper.Instance.GetRow(query, new object[] { UserSession.UserLoginUserName, committeeId });
            if (row != null)
            {
                return new DutyDAL(
                    row["task_description"].ToString() ?? string.Empty,
                    Convert.ToDateTime(row["deadline"]),
                    row["status_id"].ToString() ?? string.Empty
                );
            }
            return null;
        }

        public bool UpdateDutyStatus(string status_name, string committeeName)
        {
            int committeeId = CommitteeDAL.GetCommitteeId(committeeName);
            int status_Id = GetStatus_id(status_name);

            string query = "UPDATE duties SET status_id = @status_Id WHERE committee_id = @committeeId and assigned_to =@UserLoginUserName";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { status_Id, committeeId, UserSession.UserLoginUserName }) > 0;
        }
        public int GetStatus_id(string status) 
        {
            string query = "SELECT lookup_id from lookup where value =@status";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { status })); 
        }

       public  DutyDAL()
        {
            this.description = string.Empty;
            this.status = string.Empty;
        }
    }
}
