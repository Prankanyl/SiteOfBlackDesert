using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using SiteOfBlackDesert.Data.Models;

namespace SiteOfBlackDesert.Data
{
    class AppDBContent: DbContext
    {
       public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
       { 

       }

        public DbSet<Items> Items { get; set; }
        public DbSet<CategoryItems> CategoryItems { get; set; }
        public DbSet<AlchemyAndCooking> AlchemyAndCooking { get; set; }
        public DbSet<CategoryAlchemyAndCooking> CategoryAlchemyAndCooking { get; set; }

    }
}
