using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces;
using MagacinData;
using MagacinBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magacin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var magacin = serviceProvider.GetRequiredService<Magacin>();
                Application.Run(magacin);
            }            
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IItemBusiness, ItemBusiness>();
            services.AddScoped<Magacin>();
        }
    }
}
