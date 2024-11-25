using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Mvc;

namespace Rhibhus.Reports.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("Admin")]
    public class AdminWebDocumentViewerController : WebDocumentViewerController
    {
        public AdminWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {
        }
    }

    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("User")]
    public class UserWebDocumentViewerController : WebDocumentViewerController
    {
        public UserWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {
        }
    }
}