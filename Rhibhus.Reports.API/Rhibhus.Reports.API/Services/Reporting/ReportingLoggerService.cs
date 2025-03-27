using DevExpress.XtraReports.Web.ClientControls;

namespace Rhibhus.Reports.API.Services.Reporting
{
    public class ReportingLoggerService : LoggerService
    {
        readonly ILogger logger;
        public ReportingLoggerService(ILogger logger)
        {
            this.logger = logger;
        }
        public override void Error(Exception exception, string message)
        {
            var logMessage = $"[{DateTime.Now}]: Exception occurred. Message: '{message}'. Exception Details:{Environment.NewLine}{exception}";
            logger.LogError(logMessage);
        }

        public override void Info(string message)
        {
            logger.LogInformation(message);
        }
    }
}
