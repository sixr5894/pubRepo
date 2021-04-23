using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.Shop;

namespace Repository.Context
{
    public static class ContextExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SHPUser>().HasData(
            new  { Name = "user", ID = 1 , Role = 1}
            );
        }
    }
}
