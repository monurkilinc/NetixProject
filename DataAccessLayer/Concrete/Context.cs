using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-VLDGDG5;database=DbNetixProject1;Integrated Security=True;Trust Server Certificate=true;User Id=SA;Password={123456789};TrustServerCertificate=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>()
                .HasOne(x => x.Computer)
                .WithMany(x=> x.Services)
                .HasForeignKey(x => x.ComputerId);

            modelBuilder.Entity<Personal>()
                .HasOne(x => x.Computer)
                .WithOne(x => x.Personal)
                .HasForeignKey<Personal>(x => x.ComputerId);

            modelBuilder.Entity<Service>()
                .HasMany(p => p.ServiceHistories)
                .WithOne(b => b.Service)
                .HasForeignKey(b => b.ServiceId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
                
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ServiceHistory> ServiceHistories { get; set; }
    }
}
