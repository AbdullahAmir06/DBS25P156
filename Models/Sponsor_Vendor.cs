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


        public string fromEntityType { get; set; }
        public string toEntityType { get; set; }
        public int toEntityId { get; set; }
        public int fromEntityId { get; set; }
        public int typeId { get; set; }
        public int amount { get; set; }



        public Sponsor_Vendor(string name, string contact, string servicetype)
        {
            Name = name;
            this.contact = contact;
            this.servicetype = servicetype;
        }

        public Sponsor_Vendor(string name, string contact, int typeID, int amount, int fromEntityId, int toEntityId, string fromEntityType, string toEntityType)
        {
            Name = name;
            this.contact = contact;
            this.typeId = typeID;
            this.amount = amount;
            this.fromEntityId = fromEntityId;
            this.toEntityId = toEntityId;
            this.fromEntityType = fromEntityType;
            this.toEntityType = toEntityType;

        }
        public Sponsor_Vendor(string name, string contact)
        {
            Name = name;
            this.contact = contact;
        }

        public Sponsor_Vendor() { }
    }
}
