using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string petFirstName { get; set; }
        public string petLastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime petSince { get; set; }
        public ICollection<Visits> Visits { get; set; }
        public string fullName { 
            get
            {
                return petLastName + " , " + petFirstName;
            }
                }

    }
}