using ReactiveUI;
using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;
using ReactiveUI_WPF_StartPoint.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Managers
{
    public class CalibrationManager : ReactiveObject, ICalibrationManager
    {
        UnitModel m_CurrentUnit;
        private double? m_ReadableMetadataPixelWidth;

        public CalibrationManager()
        {
           
        }

        public void SetDisplayPixelWidth(double ? pixelWidth)
        {
            CalibrationDisplayUnit = Constants.MetricUnits.FirstOrDefault(m => m.Index == 4);

            DisplayPixelWidth = pixelWidth;
        }

        public double? DisplayPixelWidth
        {
            get => m_ReadableMetadataPixelWidth;
            set => this.RaiseAndSetIfChanged(ref m_ReadableMetadataPixelWidth, value);
        }

        public UnitModel CalibrationDisplayUnit
        {
            get => m_CurrentUnit;
            set => this.RaiseAndSetIfChanged(ref m_CurrentUnit, value);
        }
    }
}
