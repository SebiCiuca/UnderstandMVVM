namespace ReactiveUI_WPF_StartPoint.ViewModels.Navigation
{
    public class UnitModel
    {
        public int Index { get; set; }
        public string ShortName { get; set; }
        public string Fullname { get; set; }
        public MeasurementTypeEnum System { get; set; }
        public int NextUnitMultiplier { get; set; }
        public int PreviousUnitMultiplier { get; set; }
    }
}
