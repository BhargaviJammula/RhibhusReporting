using DevExpress.DataAccess.Web;
using System.Reflection;

namespace Rhibhus.Reports.API.Services.Reporting
{

    public class CustomObjectDataSourceConstructorFilterService : IObjectDataSourceConstructorFilterService
    {
        readonly IObjectDataSourceWizardTypeProvider wizardTypeProvider;

        public CustomObjectDataSourceConstructorFilterService(IObjectDataSourceWizardTypeProvider wizardTypeProvider)
        {
            this.wizardTypeProvider = wizardTypeProvider ?? throw new ArgumentNullException(nameof(wizardTypeProvider));
        }

        public IEnumerable<ConstructorInfo> Filter(Type dataSourceType, IEnumerable<ConstructorInfo> constructors)
        {
            if (wizardTypeProvider.GetAvailableTypes(null).Contains(dataSourceType))
            {
                return constructors.Where(x => !x.GetParameters().Any());
            }

            return constructors;
        }
    }
}
