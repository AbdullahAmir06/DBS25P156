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
        public bool CreateEvent(string name, string description, DateTime date, string categoryName, string venueName, string committeeName)
        {
            int categoryId = eventDAL.GetCategoryIdByName(categoryName);
            int venueId = eventDAL.GetVenueIdByName(venueName);
            int committeeID = eventDAL.GetCommitteeIdByName(committeeName);
            int editionId = UserSession.SelectedEditionID;

            if(!eventDAL.ConflictCheck(venueId, date))
            {
                Event newEvent = new Event(name, description, date, editionId, categoryId, venueId, committeeID);
                if (!eventDAL.CheckEventExists(newEvent))
                {
                    return eventDAL.AddEvent(newEvent);
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

        public bool UpdateEvent(string name, DateTime date, string venueName)
        {
            int venueId = eventDAL.GetVenueIdByName(venueName);
            int eventId = eventDAL.GetEventId(name);
            //Event newEvent = new Event(name, date, venueId);
            int eventID = eventDAL.GetEventId(name);
            //Event @event = eventDAL.GetEventById(eventID);

            if (!eventDAL.ConflictCheck(venueId, date))
            {

                Event newEvent = new Event(eventId, name, "", date, 0, 0, venueId, 0);

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

        public List<string> GetEventNames()
        {
            return eventDAL.GetEventNamesByItecEdition(UserSession.SelectedEditionID);
        }

        public List<string> GetVenueNames()
        {
            return venueDAL.GetVenueNames();
        }
    }
}
