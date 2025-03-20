using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models

namespace DBS25P156.DAL
{
    public class VenueDAL
    {
        public bool CreateVenue(Venue venue)
        {
            string query = "INSERT INTO venues (venue_name, capacity, location) VALUES (@name,@capacity,@location)";
            
            return DatabaseHelper.Instance.ExecuteQuery(query, new object[] { venue.Name, venue.Capacity, venue.Location }) > 0;
        }

    }
}
