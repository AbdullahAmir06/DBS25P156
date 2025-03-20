using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DBS25P156.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time {  get; set; }
        public int EditionId { get; set; }
        public int CategoryId { get; set; }   
        public int VenueId { get; set; }
        public int CommitteeID { get; set; }

        public Event (int id, string name, string description, DateTime date, int editionId, int categoId, int venueId, int committeeID) // when access data from db
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            EditionId = editionId;
            CategoryId = categoId;
            VenueId = venueId;
            CommitteeID = committeeID;
        }
        public Event(int id, string name, string description, DateTime date,DateTime time, int editionId, int categoId, int venueId, int committeeID) // when access data from db
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Time = time;
            EditionId = editionId;
            CategoryId = categoId;
            VenueId = venueId;
            CommitteeID = committeeID;
        }

        public Event(string name, string description, DateTime date, int editionId, int categoId, int venueId, int committeeID)     // when insert data to db
        {
            Name = name;
            Description = description;
            Date = date;
            EditionId = editionId;
            CategoryId = categoId;
            VenueId = venueId;
            CommitteeID = committeeID;
        }

        public Event(string name,DateTime date,int venueId)
        {
            Name = name;
            Date = date;
            VenueId = venueId;
        }

        public Event() { }
    }
}
