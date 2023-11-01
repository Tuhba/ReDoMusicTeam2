using Microsoft.EntityFrameworkCore;
using ReDoMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Persistence.Contexts
{
    public class ReDoMusicDbContext : DbContext
    {
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Connection stringsle beraber veritbanına bağladık
        {
            optionsBuilder.UseNpgsql(Configurations.GetString("ConnectionStrings:PostgreSQL"));
        }
    }
}
