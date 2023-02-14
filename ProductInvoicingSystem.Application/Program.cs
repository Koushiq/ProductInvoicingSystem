using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductInvoicingSystem.Data.DataProvider;
using ProductInvoicingSystem.Service.Catalog;
using ProductInvoicingSystem.WindowsDesktopApplication;

namespace ProductInvoicingSystem.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        public static void Main(string[]args)
        {

            var host = Host.CreateDefaultBuilder(args)
                            .ConfigureServices(services =>
                            {
                                services.AddTransient<LoginWindow>();
                                services.AddTransient<MainWindow>();

                                services.AddScoped<IProductService, ProductService>();
                            })
                            .Build();

            var serviceProvider = host.Services;
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<LoginWindow>());

        }
    }
}