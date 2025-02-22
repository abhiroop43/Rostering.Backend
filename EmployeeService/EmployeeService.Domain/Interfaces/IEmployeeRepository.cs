using EmployeeService.Domain.Entities;

namespace EmployeeService.Domain.Interfaces;

public interface IEmployeeRepository
{
    Task AddAsync(Employee? employee);
    void Update(Employee? employee);
    void Delete(Employee? employee);
    Task<Employee?> GetByIdAsync(Guid id);
    Task<IEnumerable<Employee?>> GetAsync(int skip, int take);
}