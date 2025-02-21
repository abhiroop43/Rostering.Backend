using EmployeeService.Domain.Interfaces;
using EmployeeService.Domain.Entities;
using EmployeeService.Infrastructure.Data;

namespace EmployeeService.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Employee employee)
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

        public Task<Employee> GetByidAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetAsync(int skip, int take)
        {
            throw new NotImplementedException();
        }
    }
}
