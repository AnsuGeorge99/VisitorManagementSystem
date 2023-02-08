using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using VisitorManagementSystem.Models.VisitorForm;

namespace VisitorManagementSystem.Database
{
    public class CatalogDBContext : DbContext
    {

        public CatalogDBContext(DbContextOptions<CatalogDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Visitor> Visitor { get; set; }
    }
}

