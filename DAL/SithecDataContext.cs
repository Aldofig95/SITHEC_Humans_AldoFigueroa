using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DAL
{
    public class SithecDataContext : DbContext
    {
        public SithecDataContext(DbContextOptions<SithecDataContext> options) : base(options)
        {
        }
        public DbSet<Human> Human { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Human>().ToTable(nameof(Human));
        }
    }
}