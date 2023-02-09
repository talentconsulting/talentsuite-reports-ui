using TalentConsulting.TalentSuite.Report.UI.Web.Models;
using TalentConsulting.TalentSuite.Report.UI.Web.Helpers;
using TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Services
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/find";

        public ReportService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<ReportModel>> Find()
        {
            var response = await _client.GetAsync(BasePath);

            return await response.ReadContentAsync<List<ReportModel>>();
        }
    }
}
