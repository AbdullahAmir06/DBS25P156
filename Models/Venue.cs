using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }


        public Venue(int id, string name, string location, int capacity)
        {
            Id = id;
            Name = name;
            Location = location;
            Capacity = capacity;
        } 
        public Venue (string name, string location, int capacity)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
        }
        public Venue(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Venue() { }

    }
}
