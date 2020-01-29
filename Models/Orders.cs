﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.Models
{
    public class Orders
    {
        [Key]
        public int orderNum { get; set; }
        public int description { get; set; }
        public int orderDate { get; set; }
        public int customerID { get; set; }

        public virtual customer customer { get; set; }

    }
}