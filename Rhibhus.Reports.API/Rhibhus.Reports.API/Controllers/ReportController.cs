using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Mvc;
using Rhibhus.Reports.API.Services.Download;

namespace Rhibhus.Reports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ReportController(IReportService reportService, IWebHostEnvironment webHostEnvironment)
        {
            _reportService = reportService;
            _webHostEnvironment = webHostEnvironment; ;
        }

        [HttpPost("generate-report")]
        public async Task<IActionResult> GenerateReport([FromBody] ReportParameters parameters)
        {
            try
            {
                // Load the XtraReport from the report file or template
                XtraReport report = _reportService.GetReport(parameters.ReportType);

                // Set parameters for the report
                //report.Parameters["RecordCount"].Value = parameters.RecordCount;
                //report.Parameters["DepartmentName"].Value = parameters.DepartmentName;

                Guid newGuid = Guid.NewGuid();
                //Save report to a file and return the file URL
                string reportFilePath = Path.Combine(_webHostEnvironment.WebRootPath, "reports", $"{newGuid}.pdf");
                await report.ExportToPdfAsync(reportFilePath);

                // Return the URL where the report can be accessed
                return Ok(new { reportUrl = $"/reports/{newGuid}.pdf" });
            }
            catch (Exception ex)
            {
                return BadRequest($"Error generating report: {ex.Message}");
            }
        }

        [HttpPost("download-report")]
        public async Task<IActionResult> DownloadReport([FromBody] ReportParameters parameters)
        {
            try
            {
                // Load the XtraReport from the report file or template
                XtraReport report = _reportService.GetReport(parameters.ReportType);

                // Set parameters for the report
                //report.Parameters["RecordCount"].Value = parameters.RecordCount;
                //report.Parameters["DepartmentName"].Value = parameters.DepartmentName;

                // Generate the report and return as a file (e.g., PDF)
                byte[] reportData = await _reportService.ExportReportAsync(report, "pdf");
                return File(reportData, "application/pdf", "report.pdf");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error generating report: {ex.Message}");
            }
        }
    }

    public class ReportParameters
    {
        public string ReportType { get; set; }
        //public string DepartmentName { get; set; }
        //public string RecordCount { get; set; }
        //public string DateFrom { get; set; }
        //public string DateTo { get; set; }
    }
}
