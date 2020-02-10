﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string vetDescription { get; set; }
        public decimal VetCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<AppointmentDetail> AppointmentDetail { get; set; }
    }
}