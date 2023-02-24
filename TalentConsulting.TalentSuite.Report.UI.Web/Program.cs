using TalentConsulting.TalentSuite.Helpers.Helpers;
using TalentConsulting.TalentSuite.Report.UI.Web.Models;
using TalentConsulting.TalentSuite.Report.UI.Web.Services;
using TalentConsulting.TalentSuite.Report.UI.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<IReportService, ReportService>(c => c.BaseAddress = new Uri("https://localhost:7055/"));


// new client
//builder.Services.AddScoped<IApiClient<ReportModel>>(c => new ApiClient<ReportModel>("https://localhost:7275"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
