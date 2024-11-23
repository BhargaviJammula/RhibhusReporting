using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["TestReport"] = () => new TestReport(),
            ["EmployeeReport"] = () => new EmployeeReport(),
            ["EmployeeParamReport"] = () => new EmployeeParamReport()
        };
    }
}