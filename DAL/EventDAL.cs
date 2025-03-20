using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DBS25P156.DAL
{
    public class EventDAL
    {
        //public bool AddEvent(Event newEvent)
        //{
        //    string query = "INSERT INTO itec_events (event_name, description, event_date, itec_id, event_category_id, venue_id, committee_id) VALUES ( @newEvent.Name , @newEvent.Description , @newEvent.Date , @newEvent.EditionId , @newEvent.CategoryId , @newEvent.VenueId , @newEvent.CommitteeID )";

        //    return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Name, newEvent.Description, newEvent.Date, newEvent.EditionId, newEvent.CategoryId, newEvent.VenueId, newEvent.CommitteeID }) > 0;
        //}
        public bool AddEvent(Event newEvent)
        {
            string query = "INSERT INTO itec_events (event_name, description, event_date, itec_id, event_category_id, venue_id, committee_id) VALUES (@Name, @Description, @dateOnly, @EditionId, @CategoryId, @VenueId, @CommitteeID)";

            string dateOnly= newEvent.Date.ToString("yyyy-MM-dd");
            //string timeOnly = date.ToString("HH:mm:ss");

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Name, newEvent.Description, dateOnly, newEvent.EditionId, newEvent.CategoryId, newEvent.VenueId, newEvent.CommitteeID }) > 0;
        }

        public bool VenueAllocation(int eventId, int venueId, string date, string time)
        {
            string query = "INSERT INTO venue_allocations (event_id,venue_id,assigned_date,assigned_time) VALUES (@eventId,@venueId,@date,@time)";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { eventId, venueId, date, time }) > 0;
        }

        //public bool DeleteEvent(Event newEvent) {
        //    string query = "DELETE FROM itec_events WHERE event_id = @newEvent.Id";
        //    return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Id }) > 0;
        //}

        public bool DeleteEvent(Event newEvent)
        {
            string query = "DELETE FROM itec_events WHERE event_id = @EventId";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Id }) > 0;
        }


        //public bool UpdateEvent(Event newEvent) {
        //    string query = "UPDATE itec_events SET  event_date = @newEvent.Date, venue_id = @newEvent.VenueId WHERE event_id = @newEvent.Id";
        //    return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Date, newEvent.VenueId, newEvent.Id }) > 0;
        //}

        public bool UpdateEvent(Event newEvent)
        {
            string query = "UPDATE itec_events SET event_date = @Date, venue_id = @VenueId WHERE event_id = @EventId";
            string venueAllocationQuery = "UPDATE venue_allocations SET assigned_date = @Date, assigned_time = @Time WHERE event_id = @EventId";

            string dateOnly = newEvent.Date.ToString("yyyy-MM-dd");  // Convert C# DateTime to SQL format
            string timeOnly = newEvent.Time.ToString("HH:mm:ss");    // Convert C# Time to SQL format

            int rowsAffected = DatabaseHelper.Instance.ExecuteQuery(query, new object[] { dateOnly, newEvent.VenueId, newEvent.Id });
            int venueUpdate = DatabaseHelper.Instance.ExecuteQuery(venueAllocationQuery, new object[] { dateOnly, timeOnly, newEvent.Id });

            return (rowsAffected > 0 && venueUpdate > 0);
        }


        //public bool UpdateEvent(Event newEvent)
        //{
        //    string query = "UPDATE itec_events SET event_date = @Date, venue_id = @VenueId WHERE event_id = @EventId";

        //    return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { newEvent.Date, newEvent.VenueId, newEvent.Id }) > 0;
        //}


        public bool ConflictCheck(int venueId, DateTime date,DateTime time)
        {
            //string query = "SELECT COUNT(*) FROM itec_events WHERE event_date = @dateonly AND venue_id = @venueId";
            string query = "SELECT COUNT(*) FROM itec_events i JOIN venue_allocations v ON i.venue_id = v.venue_id AND i.event_date = v.assigned_date WHERE i.event_date = @dateOnly AND i.venue_id = @venueId AND v.assigned_time = @timeOnly";
            string dateOnly = date.ToString("yyyy-MM-dd");
            //string timeOnly = time.ToString("HH:mm:ss");
            string timeOnly = time.ToString("HH:mm:ss");
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { dateOnly, venueId,timeOnly }));
            return count > 0;
        }

        public int GetEventId(string name)
        {
            string query = "SELECT event_id FROM itec_events WHERE event_name = @Name";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }
        public bool CheckEventExists(Event newEvent)
        {
            string query = "SELECT COUNT(*) FROM itec_events WHERE event_name = @name";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { newEvent.Name }));
            return count > 0;
        }

        public int GetCategoryIdByName(string name)
        {
            string query = "SELECT event_category_id FROM event_categories WHERE category_name = @name";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }

        public int GetVenueIdByName(string name)
        {
            string query = "SELECT venue_id FROM venues WHERE venue_name = @name";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }

        public int GetCommitteeIdByName(string name, int itecId)
        {
            string query = "SELECT committee_id FROM committees WHERE committee_name = @name and itec_id=@itecId";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name, itecId }));
        }

        public List<Event> GetAllEvents()
        {
            string query = "SELECT * FROM itec_events";
            var rows = DatabaseHelper.Instance.GetData(query);
            List<Event> events = new List<Event>();
            foreach (DataRow row in rows.Rows)
            {
                events.Add(new Event(
                    Convert.ToInt32(row["event_id"]),
                    row["event_name"].ToString(),
                    row["description"].ToString(),
                    Convert.ToDateTime(row["event_date"]),
                    Convert.ToInt32(row["itec_id"]),
                    Convert.ToInt32(row["event_category_id"]),
                    Convert.ToInt32(row["venue_id"]),
                    Convert.ToInt32(row["committee_id"])
                ));
            }
            return events;
        }

        public Event GetEventById(int id)
        {
            string query = "SELECT * FROM itec_events WHERE event_id = @id";
            var row = DatabaseHelper.Instance.GetRow(query, new object[] { id });
            if (row.Count > 0)
            {
                return new Event(
                    Convert.ToInt32(row["event_id"]),
                    row["event_name"].ToString(),
                    row["description"].ToString(),
                    Convert.ToDateTime(row["event_date"]),
                    Convert.ToInt32(row["itec_id"]),
                    Convert.ToInt32(row["event_category_id"]),
                    Convert.ToInt32(row["venue_id"]),
                    Convert.ToInt32(row["committee_id"])
                );
            }
            return null;
        }

        public List<string> GetEventNamesByItecEdition(int edition)
        {
            string query = "SELECT event_name FROM itec_events WHERE itec_id = @edition";
            return DatabaseHelper.Instance.GetColumn(query, new object[] { edition }).Select(e => e?.ToString() ?? "").ToList();
        }

        public List<string> GetCommitteeName(int edition)
        {
            string query = "SELECT committee_name FROM committees WHERE itec_id = @edition";
            return DatabaseHelper.Instance.GetColumn(query, new object[] { edition }).Select(e => e?.ToString() ?? "").ToList();
        }

        public List<string> GetEventCategories()
        {
            string query = "SELECT category_name FROM event_categories ";
            return DatabaseHelper.Instance.GetColumn(query, new object[] { }).Select(e => e?.ToString() ?? "").ToList();
        }







        //public List<Event> GetEventsByCategory(int categoryId)
        //{
        //    string query = "SELECT * FROM itec_events WHERE event_category_id = @categoryId";
        //    var rows = DatabaseHelper.Instance.GetDataTable(query, new object[] { categoryId });
        //    List<Event> events = new List<Event>();
        //    foreach (var row in rows)
        //    {
        //        events.Add(new Event(
        //            Convert.ToInt32(row["event_id"]),
        //            row["event_name"].ToString(),
        //            row["description"].ToString(),
        //            Convert.ToDateTime(row["event_date"]),
        //            Convert.ToInt32(row["itec_id"]),
        //            Convert.ToInt32(row["event_category_id"]),
        //            Convert.ToInt32(row["venue_id"]),
        //            Convert.ToInt32(row["committee_id"])
        //        ));
        //    }
        //    return events;
        //}


    }
}

