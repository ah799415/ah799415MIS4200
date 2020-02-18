using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Vets
    {
        public int vetsID { get; set; }
        public string vetDescription { get; set; }
        public decimal VetCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Visits> Visits { get; set; }
    }
}