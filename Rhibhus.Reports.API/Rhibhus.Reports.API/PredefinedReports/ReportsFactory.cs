using DevExpress.XtraReports.UI;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["TestReport"] = () => new TestReport(),
            ["EmployeeReport"] = () => new EmployeeReport(),
            ["EmployeeParamReport"] = () => new EmployeeParamReport(),
            ["SimpleFeedChartReport"] = () => new SimpleFeedChartReport(),
            ["TOCReport"] = () => new TOCReport(),
            ["JsonReport"] = () => new JsonReport(),
            ["EmployeeDetailReport"] = () => new EmployeeDetailReport(),
        };
    }
}