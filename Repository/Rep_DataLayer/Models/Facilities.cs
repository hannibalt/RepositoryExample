﻿using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class Facilities
    {
        public Facilities()
        {
            Otels = new HashSet<Otels>();
        }

        public int FacilitiesId { get; set; }
        public string FacitiliesDescription { get; set; }

        public virtual ICollection<Otels> Otels { get; set; }
    }
}
