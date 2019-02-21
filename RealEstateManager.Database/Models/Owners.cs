using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.Database.Models
{
    public class Owner
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //public ICollection<PropertyOwner> PropertyOwners { get; set; }
    }
}
