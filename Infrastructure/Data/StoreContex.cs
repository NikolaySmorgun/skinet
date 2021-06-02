using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class StoreContex : DbContext
    {
        public StoreContex(DbContextOptions<StoreContex> options): base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
