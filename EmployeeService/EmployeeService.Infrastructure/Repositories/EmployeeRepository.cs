using EmployeeService.Domain.Interfaces;
using EmployeeService.Domain.Entities;
using EmployeeService.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeService.Infrastructure.Repositories
{
  public class EmployeeRepository(EmployeeDbContext context) : IEmployeeRepository
  {
    private readonly EmployeeDbContext _context = context;

    public async Task AddAsync(Employee? employee)
    {
      await _context.Employees.AddAsync(employee);
    }

    public void Update(Employee employee)
    {
      _context.Employees.Update(employee);
    }

    public void Delete(Employee employee)
    {
      employee.IsActive = false;
      Update(employee);
    }

    public async Task<Employee?> GetByIdAsync(Guid id)
    {
      return await _context.Employees.FindAsync(id);
    }

    public async Task<IEnumerable<Employee?>> GetAsync(int skip, int take)
    {
      return await _context.Employees.Skip(skip).Take(take).ToListAsync();
    }
  }
}
