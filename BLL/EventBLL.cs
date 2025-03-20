using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBS25P156.DAL;
using DBS25P156.Models;

namespace DBS25P156.BLL
{
    public class EventBLL
    {
        private EventDAL eventDAL = new EventDAL();
        private VenueDAL venueDAL = new VenueDAL();


        public bool CreateEvent(string name, string description, DateTime date,DateTime time, string categoryName, string venueName, string committeeName)
        {
            int categoryId = eventDAL.GetCategoryIdByName(categoryName);
            int venueId = eventDAL.GetVenueIdByName(venueName);
            int editionId = UserSession.SelectedEditionID;
            int committeeID = eventDAL.GetCommitteeIdByName(committeeName, editionId);

            string dateOnly = date.ToString("yyyy-MM-dd");
            //string timeOnly = date.ToString("HH:mm:ss");
            string timeOnly = time.ToString("HH:mm:ss");

            if (!eventDAL.ConflictCheck(venueId, date,time))
            {
                Event newEvent = new Event(name, description, date, editionId, categoryId, venueId, committeeID);
                if (!eventDAL.CheckEventExists(newEvent))
                {
                    eventDAL.AddEvent(newEvent);
                    int eventId = eventDAL.GetEventId(name);

                    return eventDAL.VenueAllocation(eventId, venueId, dateOnly, timeOnly);
                }
                MessageBox.Show("Event already exists with the same name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show("Event already exists with the same date and venue", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Event newEvent = new Event(name, description, date, editionId, categoryId, venueId, committeeID);

            //if (!eventDAL.CheckEventExists(newEvent))
            //{
            //    return eventDAL.AddEvent(newEvent);
            //}

            //MessageBox.Show("Event already exists with the same name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        public bool UpdateEvent(string name, DateTime date,DateTime time, string venueName)
        {
            int venueId = eventDAL.GetVenueIdByName(venueName);
            int eventId = eventDAL.GetEventId(name);
            //Event newEvent = new Event(name, date, venueId);
            int eventID = eventDAL.GetEventId(name);
            //Event @event = eventDAL.GetEventById(eventID);

            if (!eventDAL.ConflictCheck(venueId, date,time))
            {

                Event newEvent = new Event(eventId, name, "", date,time, 0, 0, venueId, 0);

                if (eventDAL.CheckEventExists(newEvent))
                {
                    return eventDAL.UpdateEvent(newEvent);
                }
                else
                {
                    MessageBox.Show("Event does not exist", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Event already exists with the same date and venue", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }

        public bool DeleteEvent(string name)
        {
            int eventId = eventDAL.GetEventId(name);
            Event newEvent = new Event(eventId, name, "", DateTime.Now, 0, 0, 0, 0);
            //Event newEvent = new Event(name, DateTime.Now, 0);
            return eventDAL.DeleteEvent(newEvent);
        }

        public Event GetSingleEvent(string name)
        {
            int eventId = eventDAL.GetEventId(name);
            return eventDAL.GetEventById(eventId);
        }



        public List<string> GetEventNames()
        {
            return eventDAL.GetEventNamesByItecEdition(UserSession.SelectedEditionID);
        }

        public List<string> GetVenueNames()
        {
            return venueDAL.GetVenueNames();
        }

        public string GetSingleVenueName(int venueId)
        {
            Venue venue = venueDAL.GetVenueById(venueId);
            return venue != null ? venue.Name : null;
        }

        public List<string> GetCommitteeNames() // move to committee dal
        {
            return eventDAL.GetCommitteeName(UserSession.SelectedEditionID);
        }

        public List<string> GetEventCategory()
        {
            return eventDAL.GetEventCategories();
        }


    }
}
