using ReactiveUI;
using ReactiveUI_WPF_StartPoint.ViewModels.Managers;
using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;

namespace ReactveUI_WPF_StartPoint
{
    public class MainWindowViewModel : ReactiveObject
    {
        public readonly ICalibrationProperties CalibrationProperties;

        public MainWindowViewModel(ICalibrationProperties calibrationProperties, ICalibrationManager calibrationManager)
        {
            CalibrationProperties = calibrationProperties;

            calibrationManager.SetDisplayPixelWidth(2.37d);
        }
    }
}
