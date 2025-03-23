using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DBS25P156.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DBS25P156.DAL
{
    public class RegistrationDAL
    {
        public EventDAL EventDAL = new EventDAL();
        public UserDAL UserDAL = new UserDAL();
        public CommitteeDAL CommitteeDAL = new CommitteeDAL();

        public List<string> GetAllEvents()
        {
            return EventDAL.GetEventCompetitionNames();
        }

        public bool singleParticipantRegistration(string eventName, string name, string email, string contact, string institution, string paymentStatus)
        {

            int role_id = GetRoleIdOfParticipantFromLookup("Student");
            string query = "INSERT INTO participants (itec_id,name,email,contact,institute,role_id) VALUES (@SelectedEditionID,@name,@email,@contact,@instutition,@role_id)";

            int count1 = Convert.ToInt32(DatabaseHelper.Instance.ExecuteQuery(query, new object[] { UserSession.SelectedEditionID, name, email, contact, institution, role_id }));

            int participant_id = GetParticipanteeId(name, contact);
            int event_id = EventDAL.GetEventId(eventName);
            int payment_id = GetRoleIdFromLookUp(paymentStatus);
            int amount = 500;

            string query2 = "INSERT INTO event_participants (event_id,participant_id,payment_status_id,fee_amount) VALUES (@event_id,@participant_id,@payment_id,@amount)";
            int count2 = Convert.ToInt32(DatabaseHelper.Instance.ExecuteQuery(query2, new object[] { event_id, participant_id, payment_id, amount }));

            if (payment_id == 14)
            {


                int type_id = GetRoleIdFromLookUp("Ticket Sales");
                string from_entity_type = "User";
                int from_entity_id = UserDAL.GetUserId(UserSession.UserLoginUserName);
                string to_entity_type = "Committee";
                int to_entity_id = CommitteeDAL.GetCommitteeIdOfSpecificEvent(event_id);
                string description = "Event Ticket Sales";

                string query3 = "INSERT INTO finances (itec_id,event_id,type_id,amount,from_entity_type,from_entity_id,to_entity_type,to_entity_id,description) VALUES (@SelectedEditionID,@event_id,@type_id,@amount,@from_entity_type,@from_entity_id,@to_entity_type,@to_entity_id,@description)";

                int count3 = Convert.ToInt32(DatabaseHelper.Instance.ExecuteQuery(query3, new object[] { UserSession.SelectedEditionID, event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description }));


                return (count3 > 0 && count2 > 0 && count1 > 0);
            }
            else
            {
                return (count2 > 0 && count1 > 0);
            }

        }
        //public bool participantRegistration(string name, string email, string contact, string institution) // 2
        //{

        //    int role_id = GetRoleIdOfParticipantFromLookup("Student");
        //    string query = "INSERT INTO participants (itec_id,name,email,contact,institute,role_id) VALUES (@SelectedEditionID,@name,@email,@contact,@instutition,@role_id)";

        //    return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { UserSession.SelectedEditionID, name, email, contact, institution, role_id })>0;
        //}

        public bool TeamParticipantRegistration(string name, string contact,string teamName) //3
        {
            int participant_id = GetParticipanteeId(name, contact);
            int team_id = GetTeamId(teamName);
            string query = "INSERT INTO team_participants (team_id,participant_id) VALUES (@team_id,@participant_id)";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { team_id,participant_id }) > 0;
        }


        public bool RegisterTeam(string eventName, string teamName) //1
        {
            int event_id = EventDAL.GetEventId(eventName);
            if (!TeamExist(teamName))
            {
                string query = "INSERT INTO teams (event_id,team_name) VALUES (@event_id,@teamName)";
                return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { event_id, teamName }) > 0;
            }
            MessageBox.Show("Team with the same Name already Exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;

        }
        public int GetTeamId(string name)
        {
            string query = "Select team_id from teams where team_name =@name";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }

        //public bool AddTeamParticipants()

        public bool TeamExist(string name)
        {
            string query = "SELECT COUNT(*) FROM teams WHERE team_name = @name";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
            return count > 0;
        }


        public int GetRoleIdFromLookUp(string category)
        {
            string query = "SELECT lookup_id from lookup where value =@category";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { category }));
        }

        public int GetRoleIdOfParticipantFromLookup(string name)
        {
            string c = "ParticipantRoles";
            string query = "SELECT lookup_id from lookup where value =@name and category =@c";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name, c }));
        }

        public int GetParticipanteeId(string name, string contact)
        {
            string query = "SELECT participant_id from participants where name = @name and contact =@contact";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name, contact }));
        }


        public bool facultyRegistration(string name,string email,string contact,string institution,string role)
        {
            int role_id = GetRoleIdOfParticipantFromLookup(role);
            string query = "INSERT INTO participants (itec_id,name,email,contact,institute,role_id) VALUES (@SelectedEditionID,@name,@email,@contact,@instutition,@role_id)";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { UserSession.SelectedEditionID, name, email, contact, institution, role_id })>0;
        }

        public List <string> getEventsForFaculty()
        {
            return EventDAL.GetEventNamesByItecEdition(UserSession.SelectedEditionID);
        }
    }
}
