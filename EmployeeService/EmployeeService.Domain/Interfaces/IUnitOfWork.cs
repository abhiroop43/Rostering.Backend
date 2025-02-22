namespace EmployeeService.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task BeginTransactionAsync();
    Task<int> SaveAsync();
    Task CommitAsync();
    Task RollBackTransactionAsync();
}