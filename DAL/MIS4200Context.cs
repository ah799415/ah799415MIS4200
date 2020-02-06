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
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Pet> Vet { get; set; }
        public DbSet<Pet> AppointmentDetails { get; set; }
        public System.Data.Entity.DbSet<ah799415MIS4200.Models.Vet> Vets { get; set; }
    }
}