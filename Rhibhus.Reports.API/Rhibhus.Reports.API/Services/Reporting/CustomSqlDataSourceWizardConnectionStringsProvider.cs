using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Web;

namespace Rhibhus.Reports.API.Services.Reporting
{
    public class CustomSqlDataSourceWizardConnectionStringsProvider : IDataSourceWizardConnectionStringsProvider
    {
        IConfiguration Configuration { get; }
        public CustomSqlDataSourceWizardConnectionStringsProvider(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public Dictionary<string, string> GetConnectionDescriptions()
        {
            var connections = Configuration.GetSection("ReportingDataConnectionStrings").AsEnumerable(makePathsRelative: true).ToDictionary(x => x.Key, x => x.Key);
            return connections;
        }

        public DataConnectionParametersBase GetDataConnectionParameters(string name)
        {
            return null;//to prevent serialization of encrypted connection parameters
        }
    }
}
