using MediatR;

namespace EmployeeService.Application.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Guid>
    {
        public Task<Guid> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
