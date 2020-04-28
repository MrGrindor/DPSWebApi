using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DPSWebApi.Models;

namespace DPSWebApi.Data
{
    public class DPSWebApiContext : DbContext
    {
        public DPSWebApiContext (DbContextOptions<DPSWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<DPSWebApi.Models.Tile> Tile { get; set; }

        public DbSet<DPSWebApi.Models.City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasOne(c => c.HomeTile)
                .WithOne(t => t.CityOnTile);


        }
    }
}
