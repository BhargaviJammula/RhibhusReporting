using Bogus;
using Rhibhus.Reports.API.Data;
using Rhibhus.Reports.API.Models;

namespace Rhibhus.Reports.API.Services
{
    public class EmployeeRepository
    {
        //readonly IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider;

        public EmployeeRepository()
        {
            // We use this parameterless constructor in the Data Source Wizard only, and not for the actual instantiation of the repository object.
            //throw new NotSupportedException();
        }

        //public EmployeeRepository(IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider)
        //{
        //    this.scopedDbContextProvider = scopedDbContextProvider ?? throw new ArgumentNullException(nameof(scopedDbContextProvider));
        //}

        public IList<Employee> GetEmployees()
        {
            //using var dbContextScope = scopedDbContextProvider.GetDbContextScope();
            //var dbContext = dbContextScope.DbContext;
            //var emps = dbContext.Employees.ToList();
            //return AddAddress(emps);
            return new List<Employee>(); 
        }

        public IList<Employee> GetEmployees(string cityName)
        {
            //using var dbContextScope = scopedDbContextProvider.GetDbContextScope();
            //var dbContext = dbContextScope.DbContext;

            //// If cityName is null or empty, return all employees
            //var query = dbContext.Employees.AsQueryable();

            //if (!string.IsNullOrWhiteSpace(cityName))
            //{
            //    query = query.Where(e => e.City.ToLower() == cityName.ToLower());
            //}

            //var emps = query.ToList();
            //return AddAddress(emps);

            return new List<Employee>();
        }

        public Patient GetPatient()
        {
            // Create a faker instance
            //var faker = new Faker<FeedChartFooter>()
            //    .RuleFor(e => e.Date, f => f.Date.Past().Date)
            //    .RuleFor(e => e.Time, f => f.Date.Past().ToShortTimeString())
            //    .RuleFor(e => e.TypeOfFeed, f => "test")
            //    .RuleFor(e => e.AmountOffered, f => f.Random.Int(1000, 1500))
            //    .RuleFor(e => e.AmountTaken, f => f.Random.Int(1000, 1500))
            //    .RuleFor(e => e.PassedUrine, f => f.Random.Int(3, 10))
            //    .RuleFor(e => e.Bowel, f => f.Random.Int(3, 10))
            //    .RuleFor(e => e.Remarks, f => "test")
            //    .RuleFor(e => e.Vomitus, f => f.Random.Int(4, 10).ToString())
            //    .RuleFor(e => e.User, f => f.Name.FullName());

            //using (var dbContextScope = scopedDbContextProvider.GetDbContextScope())
            //{
            //    var dbContext = dbContextScope.DbContext;
            //    var employee = dbContext.Employees.FirstOrDefault();
            //    return new Patient
            //    {
            //        PatientName = employee.Name,
            //        ICNo = "45098",
            //        OldICOrPassport = "M53433",
            //        MRN = "0000039639",
            //        VisitNo = "A000000001",
            //        DateOfBirth = new DateTime(1999, 12, 12),
            //        Age = "22Y 2M 25D",
            //        Sex = "Male",
            //        BloodGroup = "AB+",
            //        WardRmBedNo = "MD1 / 73 / 73B",
            //        FooterData = faker.Generate(30)
            //    };
            //}
            return new Patient();
        }

        private IList<Employee> AddAddress(List<Employee> emps)
        {
            emps.ForEach(e => { e.Addresses = GetAddresses(); });
            return emps;
        }

        private List<Address> GetAddresses()
        {
            var faker = new Faker<Address>()
                .RuleFor(a => a.Street, f => f.Address.StreetAddress())
                .RuleFor(a => a.City, f => f.Address.City())
                .RuleFor(a => a.State, f => f.Address.State())
                .RuleFor(a => a.ZipCode, f => f.Random.Number(10000, 99999).ToString())
                .RuleFor(a => a.Country, _ => "India")
                .RuleFor(a => a.Type, f => f.PickRandom(new[] { "Permanent", "Residential" }));

            return faker.Generate(2);
        }
    }
}