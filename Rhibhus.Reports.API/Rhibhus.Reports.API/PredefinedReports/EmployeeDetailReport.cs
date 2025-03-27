using System.ComponentModel;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class EmployeeDetailReport : BaseReport
    {
        public EmployeeDetailReport()
        {
            InitializeComponent();
        }

        private void EmployeeDetailReport_BeforePrint(object sender, CancelEventArgs e)
        {
            // Access the parameter value and pass it to the base class method
            var countryName = this.Parameters["countryNameParam"]?.Value?.ToString() ?? "USA";

            // Call the base method to handle language setting
            SetLanguageForReport(countryName);
        }
    }
}