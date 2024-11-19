namespace ServerSideApp.Services
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class EmployeeRepository
    {
        public EmployeeRepository()
        {

        }

        public Employee GetEmployee()
        {
            return new Employee { Id = 1, Name = "Prasad" };
        }
    }
}
