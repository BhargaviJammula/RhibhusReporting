using DevExpress.XtraReports.UI;
using Rhibhus.Reports.API.PredefinedReports;

namespace Rhibhus.Reports.API.Services.Download
{
    public interface IReportService
    {
        XtraReport GetReport(string reportType);
        Task<byte[]> ExportReportAsync(XtraReport report, string format);
    }

    public class ReportService : IReportService
    {
        public XtraReport GetReport(string reportType)
        {
            // Create and return the report based on the report type
            return reportType switch
            {
                "DownloadReport" => new DownloadReport(),// Your custom XtraReport class
                _ => throw new ArgumentException("Unknown report type"),
            };
        }

        public async Task<byte[]> ExportReportAsync(XtraReport report, string format)
        {
            using (var memoryStream = new MemoryStream())
            {
                // Export the report to the requested format (e.g., PDF)
                await report.ExportToPdfAsync(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}