namespace EmployeeService.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task<int> SaveAsync();
    Task<int> CommitAsync();
}