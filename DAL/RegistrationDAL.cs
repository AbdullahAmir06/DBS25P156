using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

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

           int count1 =Convert.ToInt32( DatabaseHelper.Instance.ExecuteQuery(query, new object[] { UserSession.SelectedEditionID, name, email, contact, institution, role_id }));

            int participant_id = GetParticipanteeId(name, contact);
            int event_id = EventDAL.GetEventId(eventName);
            int payment_id = GetRoleIdFromLookUp(paymentStatus);
            int amount = 500;

            string query2 = "INSERT INTO event_participants (event_id,participant_id,payment_status_id,fee_amount) VALUES (@event_id,@participant_id,@payment_id,@amount)";

            int count2 = Convert.ToInt32(DatabaseHelper.Instance.ExecuteQuery(query2, new object[] { event_id, participant_id, payment_id, amount }));

            int type_id = GetRoleIdFromLookUp("Ticket Sales");
            string from_entity_type = "User";
            int from_entity_id = UserDAL.GetUserId(UserSession.UserLoginUserName);
            string to_entity_type = "Committee";
            int to_entity_id = CommitteeDAL.GetCommitteeIdOfSpecificEvent(event_id);
            string description = "Event Ticket Sales";

            string query3 = "INSERT INTO finances (itec_id,event_id,type_id,amount,from_entity_type,from_entity_id,to_entity_type,to_entity_id,description) VALUES (@SelectedEditionID,@event_id,@type_id,@amount,@from_entity_type,@from_entity_id,@to_entity_type,@to_entity_id,@description)";

            int count3 = Convert.ToInt32(DatabaseHelper.Instance.ExecuteQuery(query3,new object[] { UserSession.SelectedEditionID,event_id,type_id,amount,from_entity_type,from_entity_id,to_entity_type,to_entity_id,description }));

            return (count3 > 0 && count2 > 0 && count1 > 0);
        }
        //public bool singleEventParticipationRegistration(int event_id,int participation_id,)

        //public int GetPaymentStatus(string paymentStatus)
        //{
        //    string query = "SELECT lookup_id from lookup where value =@paymentStatus";

        //    return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { paymentStatus }));
        //}

        public int GetRoleIdFromLookUp(string category)
        {
            string query = "SELECT lookup_id from lookup where value =@category";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { category }));
        }

        public int GetRoleIdOfParticipantFromLookup(string category)
        {
            string c = "ParticipantRoles";
            string query = "SELECT lookup_id from lookup where value =@category and category =@c";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { category,c }));
        }

        public int GetParticipanteeId(string name,string contact)
        {
            string query = "SELECT participant_id from participants where name = @name and contact =@contact";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query,new object[] { name, contact }));
        }


    }
}
