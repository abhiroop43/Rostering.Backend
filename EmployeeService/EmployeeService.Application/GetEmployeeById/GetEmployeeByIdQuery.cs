using EmployeeService.Domain.Entities;
using MediatR;

namespace EmployeeService.Application.GetEmployeeById
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public Guid Id { get; set; }

        public GetEmployeeByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
