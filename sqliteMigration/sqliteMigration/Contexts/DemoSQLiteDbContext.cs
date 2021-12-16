using Microsoft.EntityFrameworkCore;
using sqliteMigration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sqliteMigration.Contexts
{
    public class DemoSQLiteDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<SaleItem> SaleItems{ get; set; }

        public DemoSQLiteDbContext(DbContextOptions<DemoSQLiteDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            base.OnModelCreating(modelBuider);
        }
    }
}
