using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class CommitteeDAL
    {
        public string CommitteeName { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public string Role { get; set; }
        public string Duty { get; set; }
        public string Date { get; set; }


        public CommitteeDAL(string name, string category, string role, string duty, string date)
        {
            Name = name;
            Category = category;
            Role = role;
            Duty = duty;
            Date = date;
        }

        public CommitteeDAL() { }

        public DataTable GetPeople()
        {

            //string query = "select u.username as Name ,role_name as Category from users u join roles r on r.role_id =u.role_id where r.role_id =1 or r.role_id =2;";
            string query = "SELECT u.username AS Name, CASE WHEN r.role_id = 1 THEN 'Student' WHEN r.role_id = 2 THEN 'Faculty' END AS Category,CASE WHEN r.role_id = 1 THEN 'Volunteer' WHEN r.role_id = 2 THEN 'Faculty Advisor' END AS Role FROM users u JOIN roles r ON r.role_id = u.role_id WHERE r.role_id IN (1, 2)";

            return DatabaseHelper.Instance.GetData(query);
        }

        public DataTable GetCommitteeData(int commmitteeId)
        {
            string query = "select distinct cm.name as Name,r.role_name as Category,r2.role_name as Role,d.task_description as Duty,d.deadline as Deadline from committee_members cm join duties d on cm.committee_id = d.committee_id and cm.name = d.assigned_to join users u on u.username=cm.name join roles r on r.role_id=u.role_id join roles r2 on cm.role_id = r2.role_id where cm.committee_id =@committeeId";

            return DatabaseHelper.Instance.GetData(query, new object[] { commmitteeId });

        }

        public bool UpdateCommmitteeData(int committeeId, string name, string taskDescription, DateTime date)
        {
            //UPDATE itec_events SET event_date = @Date, venue_id = @VenueId WHERE event_id = @EventId";
            string query = "UPDATE duties SET task_description=@taskDescription, deadline =@date WHERE committee_id =@committeeId and assigned_to = @name";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { taskDescription, date, committeeId, name }) > 0;
        }

        public bool DeleteCommittee(int committeeId)
        {
            string query = "DELETE FROM committees WHERE committee_id = @committeeId";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { committeeId }) > 0;
        }

        public bool CreateCommittee(string name)
        {
            string query = "INSERT INTO committees (itec_id,committee_name) VALUES (@SelectedEditionID,@name)";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { UserSession.SelectedEditionID, name }) > 0;
        }

        public int GetCommitteeId(string name)
        {
            string query = "Select committee_id from committees where committee_name = @name and itec_id =@SelectedEditionID";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name,UserSession.SelectedEditionID }));
        }

        public List<string> GetCommitteeNames()
        {
            string query = "SELECT committee_name from committees where itec_id =@SelectedEditionID";
            return DatabaseHelper.Instance.GetColumn(query, new object[] { UserSession.SelectedEditionID }).Select(e => e?.ToString() ?? "").ToList();
        }

        public int GetRoleId(string name)
        {
            string query = "select role_id from roles where role_name =@name";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }

        //public string GetRoleName(int  roleId)
        //{
        //    string query = "select role_name from roles where role_id =@roleId";

        //    return DatabaseHelper.Instance.GetSingleValue(query, new object[] { roleId });
        //}

        public bool AddCommitteeMembers(int committeeId, string name, int roleId)
        {
            string query = "INSERT INTO committee_members (committee_id,name,role_id) Values (@committeeId,@name,@roleId)";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { committeeId, name, roleId }) > 0;
        }

        public bool AssignDuty(int committeeId, string name, string description, DateTime date, int statusId)
        {
            string query = "INSERT INTO duties (committee_id,assigned_to,task_description,deadline,status_id) VALUES (@committeeId,@name,@description,@date,@statusId)";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { committeeId, name, description, date, statusId }) > 0;
        }

        public List<string> GetCommitteeNameOfSpecificUser(string username) // used for duty update
        {
            string query = "select c.committee_name from committees c join duties d on d.committee_id = c.committee_id where d.assigned_to =@username";

            return DatabaseHelper.Instance.GetColumn(query,new object[] { username }).Select(e => e?.ToString() ?? "").ToList();
        }

        public int GetCommitteeIdOfSpecificEvent(int eventId)
        {
            string query = "SELECT committee_id from itec_events where event_id =@eventId";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query,new object[] { eventId }));
        }

    }


}
