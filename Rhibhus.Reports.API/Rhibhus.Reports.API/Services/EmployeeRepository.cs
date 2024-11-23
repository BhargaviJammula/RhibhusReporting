using Rhibhus.Reports.API.Data;
using Rhibhus.Reports.API.Models;

namespace Rhibhus.Reports.API.Services
{
    public class EmployeeRepository
    {
        readonly IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider;

        public EmployeeRepository()
        {
            // We use this parameterless constructor in the Data Source Wizard only, and not for the actual instantiation of the repository object.
            throw new NotSupportedException();
        }

        public EmployeeRepository(IScopedDbContextProvider<EmployeeDbContext> scopedDbContextProvider)
        {
            this.scopedDbContextProvider = scopedDbContextProvider ?? throw new ArgumentNullException(nameof(scopedDbContextProvider));
        }

        public IList<Employee> GetEmployees()
        {
            using (var dbContextScope = scopedDbContextProvider.GetDbContextScope())
            {
                var dbContext = dbContextScope.DbContext;
                return dbContext.Employees.ToList();
            }
        }

        public IList<Employee> GetEmployees(string cityName)
        {
            using (var dbContextScope = scopedDbContextProvider.GetDbContextScope())
            {
                var dbContext = dbContextScope.DbContext;

                // If cityName is null or empty, return all employees
                var query = dbContext.Employees.AsQueryable();

                if (!string.IsNullOrWhiteSpace(cityName))
                {
                    query = query.Where(e => e.City.ToLower() == cityName.ToLower());
                }

                return query.ToList();
            }
        }
    }
}