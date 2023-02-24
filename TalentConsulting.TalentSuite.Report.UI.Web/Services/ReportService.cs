using TalentConsulting.TalentSuite.Report.UI.Web.Models;
using TalentConsulting.TalentSuite.Report.UI.Web.Helpers;
using TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces;
using System.Text.Json;

using TalentConsulting.TalentSuite.Reports.Common;
using TalentConsulting.TalentSuite.Reports.Common.Entities;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Services
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/reports";

        public ReportService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<PaginatedList<ReportDto>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<PaginatedList<ReportDto>>();

        }

        
    }
}
