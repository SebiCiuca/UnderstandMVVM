using Microsoft.Extensions.DependencyInjection;
using ReactiveUI;
using ReactiveUI_WPF_StartPoint.ViewModels.Managers;
using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;
using Splat;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;

namespace ReactveUI_WPF_StartPoint
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        static App()
        {
            Locator.CurrentMutable.RegisterViewsForViewModels(typeof(App).Assembly);
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainWindow>();

            services.AddSingleton<ICalibrationProperties, CalibrationProperties>();
            services.AddSingleton<ICalibrationManager, CalibrationManager>();
        }
    }
}
