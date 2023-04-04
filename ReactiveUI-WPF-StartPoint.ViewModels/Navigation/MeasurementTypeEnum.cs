using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReactiveUI_WPF_StartPoint.ViewModels.Navigation
{
    public enum MeasurementTypeEnum
    {
        [Display(Name = "Metric", Order = 1, ShortName = "M")]
        Metric,
        [Display(Name = "Ampere", Order = 2, ShortName = "A")]
        Ampere,
        [Display(Name = "Voltage", Order = 3, ShortName = "V")]
        Voltage,
        [Display(Name = "Pixel", Order = 4, ShortName = "Pix")]
        Pixel,
        Unknown
    }
}
