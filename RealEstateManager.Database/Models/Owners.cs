using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateManager.Database.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime SellDate { get; set; }
        public double PurchaseValue { get; set; }
        public double SellValue { get; set; }

        public ICollection<Property> HistoricalProperties { get; set; }
    }
}
