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

            var fileTypeParam = this.Parameters["fileTypeParam"]?.Value?.ToString() ?? "0";

            // string jsonUrl = await GetFilePath(fileTypeParam);

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

        private async Task<string> GetFilePath(string fileType)
        {
            using HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:6001"); // Express.js API base URL

            HttpResponseMessage response = await client.GetAsync($"/get-file/{fileType}");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<FileResponse>();
                Console.WriteLine($"File Type: {result?.FileType}");
                Console.WriteLine($"File URL: {result?.Url}");
                return result?.Url ?? string.Empty;
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
                string errorMessage = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Message: {errorMessage}");
                return errorMessage;
            }
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

    class FileResponse
    {
        public string? FileType { get; set; }
        public string? Url { get; set; }
    }
}
