namespace EmployeeService.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfJoining { get; set; }
        public List<string> Skills { get; set; }
    }
}
