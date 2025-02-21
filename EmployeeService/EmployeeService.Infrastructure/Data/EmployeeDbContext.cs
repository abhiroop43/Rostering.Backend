using EmployeeService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Infrastructure.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
