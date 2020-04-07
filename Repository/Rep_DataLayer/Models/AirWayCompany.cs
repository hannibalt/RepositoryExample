using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class AirWayCompany
    {
        public AirWayCompany()
        {
            AirShips = new HashSet<AirShips>();
        }

        public int AirWayId { get; set; }
        public string AirWayCompName { get; set; }

        public virtual ICollection<AirShips> AirShips { get; set; }
    }
}
