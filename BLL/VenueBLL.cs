using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.Models;
using DBS25P156.DAL;

namespace DBS25P156.BLL
{
    public class VenueBLL
    {
        public VenueDAL venueDAL = new VenueDAL();

        public bool AddVenue(string name, string location, int capacity)
        {
            if (!venueDAL.CheckIfVenueExists(name))
            {
                Venue venue = new Venue(name, location, capacity);
                MessageBox.Show("Venue Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return venueDAL.CreateVenue(venue);
            }
            else
            {
                MessageBox.Show("Venue already exists ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool UpdateVenue(string name, string location, int capacity)
        {
            int Id = venueDAL.GetVenueId(name);
            
            Venue venue = new Venue(Id, name, location, capacity);
            return venueDAL.UpdateVenue(venue);
        }

        public bool DeleteVenue(string name)
        {
            int Id = venueDAL.GetVenueId(name);
            Venue venue = new Venue(Id, name);

            return venueDAL.DeleteVenue(venue);
        }

        public Venue GetVenueById(int id)
        {
            return venueDAL.GetVenueById(id);
        }

        public List<string> GetVenueNames()
        {
            return venueDAL.GetVenueNames();
        }

        public Venue GetVenueDetail(string name)
        {
            int Id= venueDAL.GetVenueId(name);
            Venue venue =  venueDAL.GetVenueById(Id);
            return venue;
        }

    }
}
