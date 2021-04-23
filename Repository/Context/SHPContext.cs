using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.Context
{
    public class SHPContext : DbContext
    {
        public SHPContext() : base() { Database.EnsureCreated(); }
        public DbSet<SHPUser> Users { get; set; }
        public DbSet<SHPOrder> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=" + Directory.GetCurrentDirectory() + @"\shop.db");
        }

    }
}
