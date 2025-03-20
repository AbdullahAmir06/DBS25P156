using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;

namespace DBS25P156.DAL
{
    public class VenueDAL
    {
        public bool CreateVenue(Venue venue)
        {
            string query = "INSERT INTO venues (venue_name, capacity, location) VALUES (@name,@capacity,@location)";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { venue.Name, venue.Capacity, venue.Location }) > 0;
        }

        public bool UpdateVenue(Venue venue)
        {
            string query = "UPDATE venues SET capacity = @capacity , location = @location WHERE venue_id = @Id";

            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { venue.Capacity, venue.Location, venue.Id }) > 0;
        }

        public int GetVenueId(string name)
        {
            string query = "SELECT venue_id FROM venues WHERE venue_name = @name";

            return Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
        }

        public Venue GetVenueById(int id)
        {
            string query = "SELECT * FROM venues WHERE venue_id = @id";
            var row = DatabaseHelper.Instance.GetRow(query, new object[] { id });

            if (row != null && row.Count > 0) // Ensure row is not null
            {
                return new Venue(
                    Convert.ToInt32(row["venue_id"]),
                    row["venue_name"].ToString(),
                    row["location"].ToString(),
                    Convert.ToInt32(row["capacity"])
                );
            }

            return null; // Return null if no venue is found
        }

        public bool DeleteVenue(Venue venue)
        {
            string query = "DELETE FROM venues WHERE venue_id = @Id";
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { venue.Id }) > 0;
        }

        public bool CheckIfVenueExists(string name)
        {
            string query = "SELECT COUNT(*) FROM venues WHERE venue_name = @name";
            int count = Convert.ToInt32(DatabaseHelper.Instance.GetSingleValue(query, new object[] { name }));
            return count > 0;
        }

        public List<string> GetVenueNames()
        {
            string query = "SELECT venue_name FROM venues";
            return DatabaseHelper.Instance.GetColumn(query).Select(e => e?.ToString() ?? "").ToList();
        }






    }
}
