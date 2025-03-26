using Bogus;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Rhibhus.Reports.API.Models;
using System.Collections.Generic;
using System.Linq;

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
                    List<string> cities = new() { "Bangalore", "Mandya", "Horanadu", "Sringeri", "Mysore" };

                    var faker = new Faker<Employee>()
                        .RuleFor(e => e.Name, f => f.Name.FullName())
                        .RuleFor(e => e.Email, (f, e) => f.Internet.Email(e.Name))
                        .RuleFor(e => e.Age, f => f.Random.Int(30, 35))
                        .RuleFor(e => e.City, f => f.PickRandom(cities));

                    var employees = faker.Generate(100);
                    context.Employees.AddRange(employees);
                    context.SaveChanges();
                }
            }
        }
    }
}
