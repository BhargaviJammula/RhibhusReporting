using System;
using DevExpress.XtraReports.Web.ClientControls;
using Microsoft.Extensions.Logging;

namespace ServerSideApp.Services.Reporting {
    public class ReportingLoggerService: LoggerService {
        readonly ILogger logger;
        public ReportingLoggerService(ILogger logger) {
            this.logger = logger;
        }
        public override void Error(Exception exception, string message) {
            var logMessage = $"[{DateTime.Now}]: Exception occurred. Message: '{message}'. Exception Details:{Environment.NewLine}{exception}";
            logger.LogError(logMessage);
        }

        public override void Info(string message) {
            logger.LogInformation(message);
        }
    }
}
