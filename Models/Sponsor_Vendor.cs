using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P156.Models
{
    public class Sponsor_Vendor
    {
        public string Name { get; set; }
        public string contact { get; set; }
        public string servicetype { get; set; }


        public Sponsor_Vendor(string name, string contact, string servicetype)
        {
            Name = name;
            this.contact = contact;
            this.servicetype = servicetype;
        }

        public Sponsor_Vendor(string name ,string contact)
        {
            Name = name; 
            this.contact = contact;
        }

        public Sponsor_Vendor() { }
    }
}
