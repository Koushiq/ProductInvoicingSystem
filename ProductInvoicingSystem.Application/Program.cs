using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductInvoicingSystem.Data.DataProvider;
using ProductInvoicingSystem.Service.Catalog;

namespace ProductInvoicingSystem.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //static void ExemplifyServiceLifetime(IServiceProvider hostProvider, string lifetime)
        //{
        //    using IServiceScope serviceScope = hostProvider.CreateScope();
        //    IServiceProvider provider = serviceScope.ServiceProvider;
        //    ServiceLifetimeReporter logger = provider.GetRequiredService<ServiceLifetimeReporter>();
        //    logger.ReportServiceLifetimeDetails(
        //        $"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeLogger>()");

        //    Console.WriteLine("...");

        //    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
        //    logger.ReportServiceLifetimeDetails(
        //        $"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeLogger>()");

        //    Console.WriteLine();
        //}
        [STAThread]
        public static void Main(string[]args)
        {

            var host = Host.CreateDefaultBuilder(args)
                            .ConfigureServices(services =>
                            {
                                services.AddTransient<LoginWindow>();
                                services.AddScoped<IProductService, ProductService>();
                            })
                            .Build();

            var serviceProvider = host.Services;
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<LoginWindow>()); 
            //host.Run();

        }
    }
}