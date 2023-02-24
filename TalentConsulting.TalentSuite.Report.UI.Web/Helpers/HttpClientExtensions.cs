using System.Text.Json;
using TalentConsulting.TalentSuite.Reports.Common;
using TalentConsulting.TalentSuite.Reports.Common.Entities;

namespace TalentConsulting.TalentSuite.Report.UI.Web.Helpers
{
    public static class HttpClientExtensions
    {
        public static async Task<PaginatedList<ReportDto>> ReadContentAsync<T>(this HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode == false)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");

            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);



            var result =  await JsonSerializer.DeserializeAsync<PaginatedList<ReportDto>>(await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new PaginatedList<ReportDto>();


            //var result = JsonSerializer.Deserialize<T>(
              //  dataAsString, new JsonSerializerOptions
                //{
                 //   PropertyNameCaseInsensitive = true
               // });

            return result;
        }
    }
}