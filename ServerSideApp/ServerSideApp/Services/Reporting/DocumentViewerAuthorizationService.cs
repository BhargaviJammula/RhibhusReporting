using DevExpress.XtraReports.Web.WebDocumentViewer;

namespace ServerSideApp.Services.Reporting
{
    class DocumentViewerAuthorizationService : WebDocumentViewerOperationLogger, IWebDocumentViewerAuthorizationService, IExportingAuthorizationService
    {
        public bool CanCreateDocument()
        {
            return true;
        }

        public bool CanCreateReport()
        {
            return true;
        }

        public bool CanReadDocument(string documentId)
        {
            return true;
        }

        public bool CanReadExportedDocument(string id)
        {
            return true;
        }

        public bool CanReadReport(string reportId)
        {
            return true;
        }

        public bool CanReleaseDocument(string documentId)
        {
            return true;
        }

        public bool CanReleaseReport(string reportId)
        {
            return true;
        }
    }
}
