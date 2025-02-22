using EmployeeService.Domain.Interfaces;
using EmployeeService.Infrastructure.Data;
using EmployeeService.Infrastructure.Repositories;

namespace EmployeeService.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDbContext _context;
        private EmployeeRepository _employeeRepository;

        public UnitOfWork(EmployeeDbContext context)
        {
            _context = context;
        }

        public IEmployeeRepository Employees => _employeeRepository ?? new EmployeeRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task CommitAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }

        public async Task RollBackTransactionAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }
}
