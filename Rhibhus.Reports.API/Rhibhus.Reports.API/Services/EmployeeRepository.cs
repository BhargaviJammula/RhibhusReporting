using Bogus;
using Rhibhus.Reports.API.Data;
using Rhibhus.Reports.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rhibhus.Reports.API.Services
{
    public class EmployeeRepository
    {
        private readonly IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider;

        #region Constructors

        public EmployeeRepository(IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider)
        {
            this.scopedDbContextProvider = scopedDbContextProvider ?? throw new ArgumentNullException(nameof(scopedDbContextProvider));
        }

        public EmployeeRepository()
        {
            throw new NotSupportedException();
        }

        #endregion

        #region Employee Methods

        // Get all employees and generate dynamic addresses
        public IList<Employee> GetEmployees()
        {
            return ExecuteDbContext(dbContext =>
            {
                var employees = dbContext.Employees.ToList();

                foreach (var employee in employees)
                {
                    employee.Addresses = GenerateDynamicAddresses();

                    // ✅ Debug Log to Verify Addresses
                    Console.WriteLine($"Employee: {employee.Name}");
                    foreach (var address in employee.Addresses)
                    {
                        Console.WriteLine($"   Address: {address.Street}, {address.City}, {address.State}, {address.ZipCode}, {address.Country}, {address.Type}");
                    }
                }

                return employees;
            });
        }


        // Get employees filtered by city and generate dynamic addresses
        public IList<Employee> GetEmployees(string cityName)
        {
            return ExecuteDbContext(dbContext =>
            {
                var query = dbContext.Employees.AsQueryable();

                if (!string.IsNullOrWhiteSpace(cityName))
                {
                    query = query.Where(e => e.City.ToLower() == cityName.ToLower());
                }

                var employees = query.ToList();

                // Generate dynamic addresses for each employee
                foreach (var employee in employees)
                {
                    employee.Addresses = GenerateDynamicAddresses();
                }

                return employees;
            });
        }

        #endregion

        #region Patient Methods

        // Get patient details with generated data
        public Patient GetPatient()
        {
            var faker = CreateFeedChartFaker();

            return ExecuteDbContext(dbContext =>
            {
                var employee = dbContext.Employees.FirstOrDefault();
                if (employee == null)
                {
                    throw new InvalidOperationException("No employees found in the database.");
                }

                return CreatePatient(employee, faker);
            });
        }

        #endregion

        #region Private Helper Methods

        // Execute a function within a DB context scope
        private T ExecuteDbContext<T>(Func<EmployeeDbContext, T> dbContextAction)
        {
            using (var dbContextScope = scopedDbContextProvider.GetDbContextScope())
            {
                var dbContext = dbContextScope.DbContext;
                return dbContextAction(dbContext);
            }
        }

        // Generate dynamic addresses (Instead of fetching from DB)
        private List<Address> GenerateDynamicAddresses()
        {
            var faker = new Faker<Address>()
                .RuleFor(a => a.Street, f => f.Address.StreetAddress())
                .RuleFor(a => a.City, f => f.Address.City())
                .RuleFor(a => a.State, f => f.Address.State())
                .RuleFor(a => a.ZipCode, f => f.Random.Number(10000, 99999).ToString())
                .RuleFor(a => a.Country, _ => "India")
                .RuleFor(a => a.Type, f => f.PickRandom(new[] { "Permanent", "Residential", }));

            return faker.Generate(2); // Generate 2 dynamic addresses per employee
        }

        // Create a Faker for FeedChartFooter
        private Faker<FeedChartFooter> CreateFeedChartFaker()
        {
            return new Faker<FeedChartFooter>()
                .RuleFor(e => e.Date, f => f.Date.Past().Date)
                .RuleFor(e => e.Time, f => f.Date.Past().ToShortTimeString())
                .RuleFor(e => e.TypeOfFeed, f => "test")
                .RuleFor(e => e.AmountOffered, f => f.Random.Int(1000, 1500))
                .RuleFor(e => e.AmountTaken, f => f.Random.Int(1000, 1500))
                .RuleFor(e => e.PassedUrine, f => f.Random.Int(3, 10))
                .RuleFor(e => e.Bowel, f => f.Random.Int(3, 10))
                .RuleFor(e => e.Remarks, f => "test")
                .RuleFor(e => e.Vomitus, f => f.Random.Int(4, 10).ToString())
                .RuleFor(e => e.User, f => f.Name.FullName());
        }

        // Create a Patient object based on an employee and faker data
        private Patient CreatePatient(Employee employee, Faker<FeedChartFooter> faker)
        {
            return new Patient
            {
                PatientName = employee.Name,
                ICNo = "45098",
                OldICOrPassport = "M53433",
                MRN = "0000039639",
                VisitNo = "A000000001",
                DateOfBirth = new DateTime(1999, 12, 12),
                Age = "22Y 2M 25D",
                Sex = "Male",
                BloodGroup = "AB+",
                WardRmBedNo = "MD1 / 73 / 73B",
                FooterData = faker.Generate(30)
            };
        }

        #endregion
    }
}
