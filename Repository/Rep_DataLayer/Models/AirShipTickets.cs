﻿using System;
using System.Collections.Generic;

namespace Rep_DataLayer.Models
{
    public partial class AirShipTickets
    {
        public int TicketId { get; set; }
        public int? ExpeditionId { get; set; }
        public int? CustomerNumb { get; set; }

        public virtual Customers CustomerNumbNavigation { get; set; }
        public virtual AirShipExpedition Expedition { get; set; }
    }
}
