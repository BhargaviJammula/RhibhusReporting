using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Security.Resources;
using DevExpress.Utils;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rhibhus.Reports.API.Data;
using Rhibhus.Reports.API.MultilingualData.Localization;
using Rhibhus.Reports.API.Services;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDevExpressControls();
builder.Services.AddControllers();
builder.Services.ConfigureReportingServices(configurator =>
{
    if (builder.Environment.IsDevelopment())
    {
        configurator.UseDevelopmentMode();
    }
    configurator.ConfigureReportDesigner(designerConfigurator =>
    {
    });
    configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
    {
        viewerConfigurator.UseCachedReportSourceBuilder();
        //viewerConfigurator.RegisterConnectionProviderFactory<CustomSqlDataConnectionProviderFactory>();
    });
});

ServiceRegistrator.AddCommonServices(builder.Services, builder.Environment.ContentRootPath);

builder.Services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
//builder.Services.AddSingleton<IScopedDbContextProvider<ReportDbContext>, ScopedDbContextProvider<ReportDbContext>>();
//builder.Services.AddSingleton<IScopedDbContextProvider<EmployeeDbContext>, ScopedDbContextProvider<EmployeeDbContext>>();
builder.Services.AddTransient<EmployeeRepository>();
builder.Services.AddTransient<LanguageService>();
builder.Services.AddLocalization();

builder.Services.Configure<RequestLocalizationOptions>(
    options =>
    {
        var supportedCultures = LocalizationConstants.SupportedLanguages.Select(l => new CultureInfo(l.Code)).ToArray();

        options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
        options.SupportedCultures = supportedCultures;
        options.SupportedUICultures = supportedCultures;
    });


DeserializationSettings.RegisterTrustedClass(typeof(EmployeeRepository));

//builder.Services.AddDbContext<ReportDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("ReportsDataConnectionString")));

//builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultMSSqlConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowCorsPolicy", builder =>
    {
        // Allow all ports on local host.
        //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        builder.WithOrigins("*");
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//DatabaseInitilaizer.Seed(app);
//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    services.GetService<ReportDbContext>().InitializeDatabase();
//}
var contentDirectoryAllowRule = DirectoryAccessRule.Allow(new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, "Content")).FullName);
AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow());
app.UseDevExpressControls();
System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var localizeOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>();
app.UseRequestLocalization(localizeOptions.Value);

//app.UseHttpsRedirection();
app.UseCors("AllowCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();