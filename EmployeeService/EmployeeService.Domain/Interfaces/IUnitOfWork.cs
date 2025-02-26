namespace EmployeeService.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
  IEmployeeRepository Employees { get; }
  Task BeginTransactionAsync();
  Task<int> SaveAsync();
  Task CommitAsync();
  Task RollBackTransactionAsync();
}
