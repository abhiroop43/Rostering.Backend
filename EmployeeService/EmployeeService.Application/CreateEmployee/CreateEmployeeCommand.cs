using MediatR;

namespace EmployeeService.Application.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public List<string> Skills { get; set; }
    }
}
