using DevExpress.XtraReports.UI;
using Rhibhus.Reports.API.Services;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class EmployeeDetailReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EmployeeDetailReport()
        {
            InitializeComponent();
        }

        private void EmployeeDetailReport_BeforePrint(object sender, CancelEventArgs e)
        {
            string fileName = "english.json";

            var countryName = this.Parameters["countryNameParam"]?.Value?.ToString() ?? "USA";

            switch (countryName.ToLower()) // Use ToLower() for case-insensitive comparison
            {
                case "malaysia":
                    fileName = "malaysia.json";
                    break;
                case "taiwan":
                    fileName = "taiwan.json";
                    break;
                case "indonesia":
                    fileName = "indonesia.json";
                    break;
                case "usa":
                    fileName = "english.json";
                    break;
            }

            var languageData = new LanguageService().ReadJsonFromFile(fileName);

            //this.FindControl("xrId", true).Text = languageData.GetValue("Id")?.ToString();
            this.FindControl("xrName", true).Text = languageData.GetValue("Name")?.ToString();
            //this.FindControl("xrEmail", true).Text = languageData.GetValue("Email")?.ToString();
            //this.FindControl("xrAge", true).Text = languageData.GetValue("City")?.ToString();
            //this.FindControl("xrCity", true).Text = languageData.GetValue("Age")?.ToString();
        }
    }
}
