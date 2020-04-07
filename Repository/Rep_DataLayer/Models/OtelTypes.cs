using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class OtelTypes
    {
        public OtelTypes()
        {
            Otels = new HashSet<Otels>();
        }

        public int TypesId { get; set; }
        public string TypesDescription { get; set; }

        public virtual ICollection<Otels> Otels { get; set; }
    }
}
