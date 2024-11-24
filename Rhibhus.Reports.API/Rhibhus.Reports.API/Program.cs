using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using DevExpress.AspNetCore;
using DevExpress.AspNetCore.Reporting;
using DevExpress.Security.Resources;
using DevExpress.XtraReports.Web.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rhibhus.Reports.API.Services;
using Rhibhus.Reports.API.Data;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using Rhibhus.Reports.API.Services.Download;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDevExpressControls();
builder.Services.AddControllers();
builder.Services.ConfigureReportingServices(configurator => {
    if(builder.Environment.IsDevelopment()) {
        configurator.UseDevelopmentMode();
    }
    configurator.ConfigureReportDesigner(designerConfigurator => {
    });
    configurator.ConfigureWebDocumentViewer(viewerConfigurator => {
        viewerConfigurator.UseCachedReportSourceBuilder();
        viewerConfigurator.RegisterConnectionProviderFactory<CustomSqlDataConnectionProviderFactory>();
    });
});

ServiceRegistrator.AddCommonServices(builder.Services, builder.Environment.ContentRootPath);

builder.Services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddSingleton<IScopedDbContextProvider<ReportDbContext>, ScopedDbContextProvider<ReportDbContext>>();
builder.Services.AddSingleton<IScopedDbContextProvider<EmployeeDbContext>, ScopedDbContextProvider<EmployeeDbContext>>();
builder.Services.AddTransient<EmployeeRepository>();
DeserializationSettings.RegisterTrustedClass(typeof(EmployeeRepository));

builder.Services.AddDbContext<ReportDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("ReportsDataConnectionString")));

builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultMSSqlConnection")));

builder.Services.AddCors(options => {
    options.AddPolicy("AllowCorsPolicy", builder => {
        // Allow all ports on local host.
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

DatabaseInitilaizer.Seed(app);
using (var scope = app.Services.CreateScope()) {    
    var services = scope.ServiceProvider;    
    services.GetService<ReportDbContext>().InitializeDatabase();
}
var contentDirectoryAllowRule = DirectoryAccessRule.Allow(new DirectoryInfo(Path.Combine(builder.Environment.ContentRootPath, "Content")).FullName);
AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow());
app.UseDevExpressControls();
System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseCors("AllowCorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();