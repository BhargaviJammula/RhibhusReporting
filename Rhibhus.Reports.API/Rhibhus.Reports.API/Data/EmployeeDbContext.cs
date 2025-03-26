using Microsoft.EntityFrameworkCore;
using Rhibhus.Reports.API.Models;

namespace Rhibhus.Reports.API.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; } // ✅ Keep Only Employees in DB

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
