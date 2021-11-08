using MediaProcessor.UI.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace MediaProcessor.UI
{
    static class Program
    {

        static IServiceProvider ServiceProvider { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new frmPrincipal());
        }


        static void ConfigureServices()
        {

            var services = new ServiceCollection();

            ServiceProvider = services.BuildServiceProvider();

        }

        public static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }

    }
}
