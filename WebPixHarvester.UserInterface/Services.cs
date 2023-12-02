using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using WebPixHarvester.LogicLayer;

namespace WebPixHarvester.UserInterface
{
    public static class Services
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ILinkGrabber, ImageGrabber>();
        }
    }
}
