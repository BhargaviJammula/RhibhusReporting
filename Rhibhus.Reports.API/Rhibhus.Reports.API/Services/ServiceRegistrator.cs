﻿using DevExpress.AspNetCore.Reporting;
using DevExpress.DataAccess.Web;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.Web.QueryBuilder.Services;
using DevExpress.XtraReports.Web.ReportDesigner.Services;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using Rhibhus.Reports.API.Services.Reporting;
using IDataSourceWizardConnectionStringsProvider = DevExpress.DataAccess.Web.IDataSourceWizardConnectionStringsProvider;

namespace Rhibhus.Reports.API.Services
{
    public class ServiceRegistrator
    {
        public static IServiceCollection AddCommonServices(IServiceCollection services, string contentRootPath)
        {
            var cacheCleanerSettings = new CacheCleanerSettings(TimeSpan.FromMinutes(1), TimeSpan.FromSeconds(30), TimeSpan.FromMinutes(2), TimeSpan.FromMinutes(2));
            services.AddSingleton<CacheCleanerSettings>(cacheCleanerSettings);

            var storageCleanerSettings = new StorageCleanerSettings(TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(30), TimeSpan.FromHours(12), TimeSpan.FromHours(12), TimeSpan.FromHours(12));
            services.AddSingleton<StorageCleanerSettings>(storageCleanerSettings);

            services.ConfigureReportingServices(configurator =>
            {
                configurator.ConfigureReportDesigner((reportDesignerConfigurator) =>
                {
                    reportDesignerConfigurator.RegisterObjectDataSourceConstructorFilterService<CustomObjectDataSourceConstructorFilterService>();
                });
                configurator.ConfigureWebDocumentViewer(viewerConfigurator =>
                {
                    // StorageSynchronizationMode.InterThread - it is a default value, use InterProcess if you use multiple application instances without ARR Affinity
                    viewerConfigurator.UseFileDocumentStorage(Path.Combine(contentRootPath, "ViewerStorages\\Documents"), StorageSynchronizationMode.InterThread);
                    viewerConfigurator.UseFileExportedDocumentStorage(Path.Combine(contentRootPath, "ViewerStorages\\ExportedDocuments"), StorageSynchronizationMode.InterThread);
                    viewerConfigurator.UseFileReportStorage(Path.Combine(contentRootPath, "ViewerStorages\\Reports"), StorageSynchronizationMode.InterThread);
                    viewerConfigurator.UseCachedReportSourceBuilder();
                });

                services.AddScoped<IReportProviderAsync, CustomReportProviderAsync>();
                configurator.UseAsyncEngine();
            });

            services.AddScoped<IReportProvider, CustomReportProvider>();
            services.AddScoped<IWebDocumentViewerExceptionHandler, CustomWebDocumentViewerExceptionHandler>();
            services.AddScoped<IReportDesignerExceptionHandler, CustomReportDesignerExceptionHandler>();
            services.AddScoped<IQueryBuilderExceptionHandler, CustomQueryBuilderExceptionHandler>();

            services.AddScoped<IWebDocumentViewerAuthorizationService, DocumentViewerAuthorizationService>();
            services.AddScoped<IExportingAuthorizationService, DocumentViewerAuthorizationService>();
            services.AddScoped<WebDocumentViewerOperationLogger, DocumentViewerAuthorizationService>();


            services.AddScoped<IObjectDataSourceInjector, ObjectDataSourceInjector>();
            services.AddScoped<PreviewReportCustomizationService, CustomPreviewReportCustomizationService>();

            services.AddScoped<IDataSourceWizardConnectionStringsProvider, CustomSqlDataSourceWizardConnectionStringsProvider>();
            services.AddScoped<IConnectionProviderService, CustomConnectionProviderService>();
            services.AddScoped<IConnectionProviderFactory, CustomSqlDataConnectionProviderFactory>();
            return services;
        }
    }
}
