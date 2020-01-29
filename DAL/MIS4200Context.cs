using System;
using System.Collections.Generic;
using System.Data.Entity;
using ah799415MIS4200.Models;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context(): base ("nameDefaultConnection")
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<customer> Customer { get; set; }
    }
}