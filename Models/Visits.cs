using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Visits
    {
        [Key]
        public int visitNum { get; set; }
        public int visitDescription { get; set; }
        public int visitDate { get; set; }
        public int petID { get; set; }

        public virtual Pet Pet { get; set; }

    }
}