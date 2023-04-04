using System.Collections.ObjectModel;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Navigation
{
    public interface ICalibrationProperties
    {   
        UnitModel SelectedMeasurementUnit { get; set; }
        ReadOnlyObservableCollection<UnitModel> MetricUnits { get; set; }
        ReadOnlyObservableCollection<UnitModel> AmperUnits { get; set; }
        ReadOnlyObservableCollection<UnitModel> VoltageUnits { get; set; }
        ReadOnlyObservableCollection<UnitModel> PixelUnits { get; set; }
    }
}
