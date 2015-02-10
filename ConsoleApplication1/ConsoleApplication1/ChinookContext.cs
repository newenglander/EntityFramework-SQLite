using ConsoleApplication1;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConsoleApplication1
{
    class ChinookContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Chinook Database does not pluralize table names
            modelBuilder.Conventions
                .Remove<PluralizingTableNameConvention>();
        }
    }
}
