using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ProductInvoicingSystem.Data.DataProvider;

namespace ProductInvoicingSystem.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            //serviceProvider.AddDbContext<ProductInvoicingSystemDbContext>(ServiceLifetime.Transient);
                                 //.AddLogging()
                                 //.AddSingleton<IFooService, FooService>()
                                 //.AddSingleton<IBarService, BarService>()
                                 //.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginWindow());


        }
    }
}