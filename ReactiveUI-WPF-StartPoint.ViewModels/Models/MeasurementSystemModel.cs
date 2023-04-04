using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;
using ReactiveUI_WPF_StartPoint.ViewModels.Utils;
using System.ComponentModel.DataAnnotations;
using Constants = ReactiveUI_WPF_StartPoint.ViewModels.Utils.Constants;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Models
{
    public class MeasurementSystemModel
    {
        private MeasurementTypeEnum _type;
        public MeasurementTypeEnum Type => _type;

        private LinkedList<UnitModel> _units;
        public LinkedList<UnitModel> Units => _units;

        public UnitModel DefaultUnit => Units.FirstOrDefault(u => u.Index == 0);

        private string _shortName;
        public string ShortName => _shortName;

        public MeasurementSystemModel(MeasurementTypeEnum type)
        {
            _type = type;
            _units = GetUnits();

            if (type != MeasurementTypeEnum.Unknown)
            {
                _shortName = type.GetAttribute<DisplayAttribute>().ShortName;
            }
        }

        private LinkedList<UnitModel> GetUnits()
        {
            switch (_type)
            {
                case MeasurementTypeEnum.Metric:
                    return new LinkedList<UnitModel>(Constants.MetricUnits);
                case MeasurementTypeEnum.Ampere:
                    return new LinkedList<UnitModel>(Constants.AmpereUnits);
                case MeasurementTypeEnum.Voltage:
                    return new LinkedList<UnitModel>(Constants.VoltUnits);
                case MeasurementTypeEnum.Pixel:
                    return new LinkedList<UnitModel>(Constants.PixelUnits);
                default:
                    return null;
            }
        }
    }
}
