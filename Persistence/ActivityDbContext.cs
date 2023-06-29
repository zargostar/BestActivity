using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ActivityDbContext : DbContext
    {
        public ActivityDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Activity> Activities {set;get;}
   
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Category>()
                .HasMany(p=>p.Products)
                .WithOne(c=>c.Category).
                OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}