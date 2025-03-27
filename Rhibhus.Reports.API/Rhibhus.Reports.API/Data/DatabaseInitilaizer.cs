using Bogus;
using Rhibhus.Reports.API.Models;

namespace Rhibhus.Reports.API.Data
{
    public class DatabaseInitilaizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EmployeeDbContext>();

                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                if (!context.Employees.Any())
                {
                    // Define a list of cities
                    List<string> cities = new() { "Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore" };

                    // Create a faker instance
                    var faker = new Faker<Employee>()
                        .RuleFor(e => e.Name, f => f.Name.FullName())
                        .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.Name))
                        .RuleFor(e => e.Age, f => f.Random.Int(30, 35)) // All employees have similar age (between 30 and 35)
                        .RuleFor(e => e.City, f => f.PickRandom(cities)); // Randomly pick a city from the list

                    var employeeToAdd = faker.Generate(10);

                    context.Employees.AddRange(employeeToAdd);
                    context.SaveChanges();
                }
            }
        }
    }
}
