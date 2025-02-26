using EmployeeService.Domain.Entities;
using MediatR;

namespace EmployeeService.Application.GetEmployeeById
{
  public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
  {
    public Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
