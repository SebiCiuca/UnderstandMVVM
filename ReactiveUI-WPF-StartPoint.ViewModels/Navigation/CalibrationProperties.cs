using ReactiveUI;
using ReactiveUI_WPF_StartPoint.ViewModels.Managers;
using ReactiveUI_WPF_StartPoint.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Navigation
{
    public class CalibrationProperties : ReactiveObject, ICalibrationProperties
    {
        private readonly ICalibrationManager m_CalibrationManager;

        private UnitModel m_SelectedMeasurementUnit;
        private ReadOnlyObservableCollection<UnitModel> m_MetricUnits;
        private ReadOnlyObservableCollection<UnitModel> m_AmperUnits;
        private ReadOnlyObservableCollection<UnitModel> m_VoltageUnits;
        private ReadOnlyObservableCollection<UnitModel> m_PixelUnits;

        public CalibrationProperties(ICalibrationManager calibrationManager)
        {
            m_CalibrationManager = calibrationManager;


            m_CalibrationManager.WhenAnyValue(cm => cm.DisplayPixelWidth)
                                .WhereNotNull()
                                .Subscribe(_ => ReloadPixelWidth());

            LoadMeasurementSystems();
        }
        private void ReloadPixelWidth()
        {
            SetCurrentUnit();
        }

        bool _readOnlySet = false;
        private void SetCurrentUnit()
        {
            _readOnlySet = true;
            SelectedMeasurementUnit = m_CalibrationManager.CalibrationDisplayUnit;
            _readOnlySet = false;
        }

        private void LoadMeasurementSystems()
        {
            var metricUnits = new MeasurementSystemModel(MeasurementTypeEnum.Metric).Units.ToList();
            var amperUnits = new MeasurementSystemModel(MeasurementTypeEnum.Ampere).Units.ToList();
            var voltUnits = new MeasurementSystemModel(MeasurementTypeEnum.Voltage).Units.ToList();
            var pixelUnits = new MeasurementSystemModel(MeasurementTypeEnum.Pixel).Units.ToList();

            MetricUnits = new ReadOnlyObservableCollection<UnitModel>
                (new ObservableCollection<UnitModel>(metricUnits));

            AmperUnits = new ReadOnlyObservableCollection<UnitModel>
                (new ObservableCollection<UnitModel>(amperUnits));

            VoltageUnits = new ReadOnlyObservableCollection<UnitModel>
                (new ObservableCollection<UnitModel>(voltUnits));

            PixelUnits = new ReadOnlyObservableCollection<UnitModel>
                (new ObservableCollection<UnitModel>(pixelUnits));

            var fullList = metricUnits;
            fullList.AddRange(amperUnits);
            fullList.AddRange(voltUnits);
            fullList.AddRange(pixelUnits);
        }
        public UnitModel SelectedMeasurementUnit
        {
            get => m_SelectedMeasurementUnit;
            set
            {
                this.RaiseAndSetIfChanged(ref m_SelectedMeasurementUnit, value);
                SetCalibrationValues(value);
            }
        }
        private void SetCalibrationValues(UnitModel newValue = null)
        {
            if (m_SelectedMeasurementUnit == null || _readOnlySet)
            {
                return;
            }

            //do something
        }

        public ReadOnlyObservableCollection<UnitModel> MetricUnits
        {
            get => m_MetricUnits;
            set => this.RaiseAndSetIfChanged(ref m_MetricUnits, value);
        }

        public ReadOnlyObservableCollection<UnitModel> AmperUnits
        {
            get => m_AmperUnits;
            set => this.RaiseAndSetIfChanged(ref m_AmperUnits, value);
        }

        public ReadOnlyObservableCollection<UnitModel> VoltageUnits
        {
            get => m_VoltageUnits;
            set => this.RaiseAndSetIfChanged(ref m_VoltageUnits, value);
        }

        public ReadOnlyObservableCollection<UnitModel> PixelUnits
        {
            get => m_PixelUnits;
            set => this.RaiseAndSetIfChanged(ref m_PixelUnits, value);
        }

    }
}
