using Microsoft.Extensions.DependencyInjection;
using WebPixHarvester.LogicLayer;

namespace WebPixHarvester.UserInterface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            Services.ConfigureServices(services);
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var grabberService = serviceProvider.GetRequiredService<ILinkGrabber>();
                Application.Run(new MainWindow(grabberService));
            }
            
        }
    }
}