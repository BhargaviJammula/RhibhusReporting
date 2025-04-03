using DevExpress.DataAccess.Json;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Rhibhus.Reports.API.PredefinedReports
{
    public partial class DynamicJsonReport : XtraReport
    {
        public DynamicJsonReport()
        {
            InitializeComponent();
        }

        private void DynamicJsonReport_BeforePrint(object sender, CancelEventArgs e)
        {
            // Fetch JSON and bind dynamically
            BindJsonData().Wait();
        }

        private async Task BindJsonData()
        {
            string jsonUrl = "https://rhibhhus-ca.s3.ap-south-1.amazonaws.com/employees.json";

            string jsonData = await GetJsonFromUrlAsync(jsonUrl);

            // Create JSON Data Source
            JsonDataSource jsonDataSource = new JsonDataSource
            {
                JsonSource = new CustomJsonSource(jsonData)
            };
            jsonDataSource.Fill(); // Load data into the report

            // Assign JSON Data Source to Report
            this.DataSource = jsonDataSource;
        }

        // Fetch JSON Data from S3 or API
        private static async Task<string> GetJsonFromUrlAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }
    }
}
