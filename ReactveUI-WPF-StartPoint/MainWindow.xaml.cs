using System.Reactive.Disposables;
using System;
using ReactiveUI;
using System.Diagnostics;
using System.Reactive.Linq;
using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;
using Splat;
using Microsoft.Extensions.DependencyInjection;

namespace ReactveUI_WPF_StartPoint
{
    public class ReactiveMainWindow : ReactiveWindow<MainWindowViewModel> { }

	public partial class MainWindow : ReactiveMainWindow
	{
        public MainWindow()
        {
            InitializeComponent();
            
            ViewModel = App.ServiceProvider.GetRequiredService<MainWindowViewModel>();

            this.WhenActivated(cleanup =>
            {
                this.OneWayBind(ViewModel,
                    vm => vm.CalibrationProperties.MetricUnits,
                    v => v.MetricUnits.ItemsSource);
                this.OneWayBind(ViewModel,
                    vm => vm.CalibrationProperties.AmperUnits,
                    v => v.AmperUnits.ItemsSource);
                this.OneWayBind(ViewModel,
                    vm => vm.CalibrationProperties.VoltageUnits,
                    v => v.VoltageUnits.ItemsSource);
                this.OneWayBind(ViewModel,
                    vm => vm.CalibrationProperties.PixelUnits,
                    v => v.PixUnits.ItemsSource);

                this.Bind(ViewModel,
                          vm => vm.CalibrationProperties.SelectedMeasurementUnit,
                          v => v.MeasurementUnitComboBoxGallery.SelectedItem)
                    .DisposeWith(cleanup);

                this.WhenAnyValue(x => x.ViewModel.CalibrationProperties.SelectedMeasurementUnit)
					.WhereNotNull()
					.Subscribe(x=> Debug.WriteLine(x.ShortName));
                this.WhenAnyValue(x => x.MeasurementUnitComboBoxGallery.SelectedItem)
                    .WhereNotNull()
                    .Select(s=> (UnitModel)s)
                    .Subscribe(x=> Debug.WriteLine(x.ShortName));
            });
        }
    }
}
