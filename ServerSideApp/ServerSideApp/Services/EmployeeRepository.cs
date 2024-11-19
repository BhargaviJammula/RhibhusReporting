using ServerSideApp.Data;
using ServerSideApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerSideApp.Services
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
    }
}