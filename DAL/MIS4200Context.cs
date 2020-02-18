﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using ah799415MIS4200.Models;
using System.Linq;
using System.Web;

namespace ah799415MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context(): base ("name=DefaultConnection")
        {
        }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Vets> Vets { get; set; }
        
    }
}