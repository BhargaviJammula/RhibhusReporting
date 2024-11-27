using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Mvc;

namespace Rhibhus.Reports.API.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("Admin")]
    public class AdminController(IWebDocumentViewerMvcControllerService controllerService) : WebDocumentViewerController(controllerService)
    {
    }
}