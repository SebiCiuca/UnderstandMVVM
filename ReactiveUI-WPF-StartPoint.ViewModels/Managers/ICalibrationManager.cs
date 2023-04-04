using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Managers
{
    public interface ICalibrationManager
    {
        public double? DisplayPixelWidth { get; }
        public UnitModel CalibrationDisplayUnit { get; }
        void SetDisplayPixelWidth(double? pixelWidth);

    }
}
