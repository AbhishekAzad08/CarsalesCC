using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarsalesCC.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarEntity> Cars { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public AppDbContext()
        {

        }

    }
}
