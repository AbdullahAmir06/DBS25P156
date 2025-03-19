using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;
using MySql.Data.MySqlClient;

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
            string query = "INSERT INTO itec_events (event_name, description, event_date, itec_id, event_category_id, venue_id, committee_id) VALUES (@Name, @Description, @Date, @EditionId, @CategoryId, @VenueId, @CommitteeID)";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[]{newEvent.Name, newEvent.Description, newEvent.Date, newEvent.EditionId,newEvent.CategoryId, newEvent.VenueId, newEvent.CommitteeID}) > 0;
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

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[]{newEvent.Date, newEvent.VenueId, newEvent.Id}) > 0;
        }

        public bool ConflictCheck(int venueId,DateTime date)
        {
            string query = "SELECT COUNT(*) FROM itec_events WHERE event_date = @date AND venue_id = @venueId";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { date, venueId }));
            return count > 0;
        }

        public int GetEventId(string name)
        {
            string query = "SELECT event_id FROM itec_events WHERE event_name = @newEvent.Name";
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

        public int GetCommitteeIdByName(string name)
        {
            string query = "SELECT committee_id FROM committees WHERE committee_name = @name";
            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
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

        public List<string> GetVenueNames()
        {
            string query = "SELECT venue_name FROM venues";
            return DatabaseHelper.Instance.GetColumn(query).Select(e => e?.ToString() ?? "").ToList();
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
