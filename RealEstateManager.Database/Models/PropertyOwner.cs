using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RealEstateManager.Database.Models
{
    public class PropertyOwner
    {
        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
