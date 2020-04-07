using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class RentcarCompany
    {
        public RentcarCompany()
        {
            ItemCars = new HashSet<ItemCars>();
        }

        public int RentcarCompanyId { get; set; }
        public string RentcarCompanyName { get; set; }

        public virtual ICollection<ItemCars> ItemCars { get; set; }
    }
}
