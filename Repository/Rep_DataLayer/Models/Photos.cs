using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class Photos
    {
        public int PhotoId { get; set; }
        public byte[] PhotoSource { get; set; }
        public int? OteleId { get; set; }

        public virtual Otels Otele { get; set; }
    }
}
