using System.Reactive.Disposables;
using ReactiveUI;

namespace ReactveUI_WPF_StartPoint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            
            ViewModel = mainWindowViewModel;

            DataContextChanged += (sender, args) => ViewModel = DataContext as MainWindowViewModel;

            this.WhenActivated(cleanup =>
            {
                MetricUnits.DataContext = ViewModel.CalibrationProperties.MetricUnits;
                AmperUnits.DataContext = ViewModel.CalibrationProperties.AmperUnits;
                VoltageUnits.DataContext = ViewModel.CalibrationProperties.VoltageUnits;
                PixUnits.DataContext = ViewModel.CalibrationProperties.PixelUnits;

                this.Bind(ViewModel,
                          vm => vm.CalibrationProperties.SelectedMeasurementUnit,
                          v => v.MeasurementUnitComboBoxGallery.SelectedItem)
                    .DisposeWith(cleanup);
            });
        }
    }
}
