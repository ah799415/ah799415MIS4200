using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Pet
    {
        public int petID { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public string petName { get; set; }
        public string ownerPhone { get; set; }
        public DateTime patientSince { get; set; }
        public ICollection<Visit> Visit { get; set; }
        public string ownerFullName { 
            get
            {
                return ownerLastName + " , " + ownerFirstName;
            }
                }

    }
}