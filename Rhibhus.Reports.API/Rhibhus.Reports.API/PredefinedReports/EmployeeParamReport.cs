using DevExpress.XtraReports.UI;
using Rhibhus.Reports.API.Services;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class EmployeeParamReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EmployeeParamReport()
        {
            InitializeComponent();
        }

        private void EmployeeParamReport_BeforePrint(object sender, CancelEventArgs e)
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

            #region Type 1

            //this.FindControl("xrId", true).Text = languageData.GetValue("Id")?.ToString();
            //this.FindControl("xrName", true).Text = languageData.GetValue("Name")?.ToString();
            //this.FindControl("xrEmail", true).Text = languageData.GetValue("Email")?.ToString();
            //this.FindControl("xrAge", true).Text = languageData.GetValue("City")?.ToString();
            //this.FindControl("xrCity", true).Text = languageData.GetValue("Age")?.ToString();

            #endregion

            #region Type 2

            //// List of control names in the report
            //string[] controlNames = new string[] { "xrId", "xrName", "xrEmail", "xrAge", "xrCity" };

            //// Corresponding keys for each control to retrieve from languageData
            //string[] dataKeys = new string[] { "Id", "Name", "Email", "Age", "City" };

            //// Loop through each control and set the text based on the corresponding language data
            //for (int i = 0; i < controlNames.Length; i++)
            //{
            //    var control = this.FindControl(controlNames[i], true);
            //    var value = languageData.GetValue(dataKeys[i])?.ToString();

            //    if (control != null && value != null)
            //    {
            //        control.Text = value;
            //    }
            //}

            #endregion

            #region Type 3

            // Iterate through each band in the collection
            foreach (Band band in this.Bands.OfType<PageHeaderBand>())
            {
                // Iterate through all controls in the current band
                foreach (XRTable control in band.Controls.OfType<XRTable>())
                {
                    var headerRow = control.Rows[0];

                    // Iterate through the cells of the header row
                    foreach (XRTableCell cell in headerRow.Cells)
                    {
                        // Retrieve the corresponding text from the language data
                        var value = languageData.GetValue(cell.Text)?.ToString();

                        if (!string.IsNullOrEmpty(value))
                        {
                            // Set the text of the header cell
                            cell.Text = value;
                        }
                    }
                }
            }

            #endregion
        }
    }
}