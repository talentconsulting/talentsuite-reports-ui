using TalentConsulting.TalentSuite.Report.UI.Web.Models;
using TalentConsulting.TalentSuite.Reports.Common;
using TalentConsulting.TalentSuite.Reports.Common.Entities;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces
{
    public interface IReportService
    {
        Task<PaginatedList<ReportDto>> Find();
    }
}
