using TalentConsulting.TalentSuite.Report.UI.Web.Models;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<ReportModel>> Find();
    }
}
