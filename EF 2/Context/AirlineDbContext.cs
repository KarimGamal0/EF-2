using EF_2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Context
{
    internal class AirlineDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Airport;Trusted_Connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Crew>().ToTable("Aircrafts").HasKey(C => C.AircraftId);

            modelBuilder.Entity<Aircraft>().HasOne(A => A.AircraftCrew).WithOne(C => C.Aircraft)
                .HasForeignKey<Crew>(C => C.AircraftId);

            modelBuilder.Entity<Aircraft>().HasMany(R => R.Routes).WithMany(A => A.Aircrafts)
                .UsingEntity(rt =>
                {
                    rt.ToTable("AircraftRoute");
                    rt.Property<int>("NumOfPassangers");
                    rt.Property<int>("Price");
                    rt.Property<TimeOnly>("Departure");
                    rt.Property<TimeOnly>("Arrival");
                    rt.Property<int>("Duration");
                }
                );

            modelBuilder.Entity<Phone>().HasKey(P => P.Number);

            

        }


        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Empolyee> Empolyees { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Aircraft> Aircrafts { get; set; }

        public DbSet<Crew> Crews { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Route> Routes { get; set; }
    }
}
