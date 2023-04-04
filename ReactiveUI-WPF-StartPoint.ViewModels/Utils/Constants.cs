using ReactiveUI_WPF_StartPoint.ViewModels.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Utils
{
    public static class Constants
    {
        public static IReadOnlyList<UnitModel> MetricUnits = new List<UnitModel>(
        new List<UnitModel>()
        {
                new UnitModel { Index = 0, Fullname = "Meter", ShortName = "m", NextUnitMultiplier = 0, PreviousUnitMultiplier = 2, System = MeasurementTypeEnum.Metric },
                new UnitModel { Index = 1, Fullname = "Centimeter", ShortName = "cm", NextUnitMultiplier = 2, PreviousUnitMultiplier = 1 , System = MeasurementTypeEnum.Metric},
                new UnitModel { Index = 2, Fullname = "Milimeter", ShortName = "mm", NextUnitMultiplier = 1, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Metric},
                new UnitModel { Index = 3, Fullname = "Micrometer", ShortName = "μm", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3 , System = MeasurementTypeEnum.Metric},
                new UnitModel { Index = 4, Fullname = "Nanometer", ShortName = "nm", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Metric},
                new UnitModel { Index = 5, Fullname = "Picometer", ShortName = "pm", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Metric},
                new UnitModel { Index = 6, Fullname = "Femtometer", ShortName = "fm" , NextUnitMultiplier = 3, PreviousUnitMultiplier = 3, System = MeasurementTypeEnum.Metric  },
                new UnitModel { Index = 7, Fullname = "Attometer", ShortName = "am", NextUnitMultiplier = 3, PreviousUnitMultiplier = 0  , System = MeasurementTypeEnum.Metric },
        });

        public static IReadOnlyList<UnitModel> AmpereUnits = new List<UnitModel>(
          new List<UnitModel>()
          {
                new UnitModel { Index = 0, Fullname = "Ampere", ShortName = "A", NextUnitMultiplier = 0, PreviousUnitMultiplier = 3       , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 1, Fullname = "Milliampere", ShortName = "mA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3 , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 2, Fullname = "Microampere", ShortName = "µA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3 , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 3, Fullname = "Nanoampere", ShortName = "nA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 4, Fullname = "Picoampere", ShortName = "pA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 5, Fullname = "Femtoampere", ShortName = "fA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3 , System = MeasurementTypeEnum.Ampere},
                new UnitModel { Index = 6, Fullname = "Attoampere", ShortName = "aA", NextUnitMultiplier = 3, PreviousUnitMultiplier = 0  , System = MeasurementTypeEnum.Ampere}
          });

        public static IReadOnlyList<UnitModel> VoltUnits = new List<UnitModel>(
         new List<UnitModel>()
         {
                new UnitModel { Index = 0, Fullname = "Megavolt", ShortName = "MV", NextUnitMultiplier = 0, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Voltage },
                new UnitModel { Index = 1, Fullname = "Kilovolt", ShortName = "kV", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3  , System = MeasurementTypeEnum.Voltage },
                new UnitModel { Index = 2, Fullname = "Volt", ShortName = "V", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3       , System = MeasurementTypeEnum.Voltage },
                new UnitModel { Index = 3, Fullname = "Millivolt", ShortName = "mV", NextUnitMultiplier = 3, PreviousUnitMultiplier = 3 , System = MeasurementTypeEnum.Voltage },
                new UnitModel { Index = 4, Fullname = "Microvolt", ShortName = "μV", NextUnitMultiplier = 3, PreviousUnitMultiplier = 0 , System = MeasurementTypeEnum.Voltage },
         });

        public static IReadOnlyList<UnitModel> PixelUnits = new List<UnitModel>(
         new List<UnitModel>()
         {
                new UnitModel { Index = 0, Fullname = "Pixel", ShortName = "Pix", NextUnitMultiplier = 0, PreviousUnitMultiplier = 0, System = MeasurementTypeEnum.Pixel },
         });
    }
}
