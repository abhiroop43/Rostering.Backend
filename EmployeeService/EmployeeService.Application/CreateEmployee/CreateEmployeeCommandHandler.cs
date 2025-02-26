using EmployeeService.Domain.Entities;
using EmployeeService.Domain.Interfaces;
using MediatR;

namespace EmployeeService.Application.CreateEmployee
{
  public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Guid>
  {
    private readonly IUnitOfWork _unitOfWork;

    public CreateEmployeeCommandHandler(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
    {
      // TODO: use automapper
      var employee = new Employee
      {
        Id = Guid.NewGuid(),
        FirstName = request.FirstName,
        LastName = request.LastName,
        Email = request.Email,
        Skills = request.Skills,
        DateOfJoining = request.DateOfJoining,
        CreatedBy = "admin",
        CreatedDate = DateTime.Now
      };

      await _unitOfWork.Employees.AddAsync(employee);
      await _unitOfWork.SaveAsync();

      return employee.Id;
    }
  }
}
