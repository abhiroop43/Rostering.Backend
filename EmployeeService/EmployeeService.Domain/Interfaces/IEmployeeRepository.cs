using EmployeeService.Domain.Entities;

namespace EmployeeService.Domain.Interfaces;

public interface IEmployeeRepository
{
    Task AddAsync(Employee employee);
    void Update(Employee employee);
    void Delete(Employee employee);
    Task<Employee> GetByidAsync(Guid id);
    Task<IEnumerable<Employee>> GetAsync(int skip, int take);
}