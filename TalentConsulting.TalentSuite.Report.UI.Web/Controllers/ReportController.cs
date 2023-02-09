using Microsoft.AspNetCore.Mvc;
using TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Controllers
{
    public class ReportController : Controller
    {
        private readonly IReportService _service;

        public ReportController(IReportService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public async Task<IActionResult> Index()
        {
            var items = await _service.Find();
            return View(items);
        }
    }
}