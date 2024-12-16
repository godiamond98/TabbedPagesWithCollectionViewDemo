using CommunityToolkit.Mvvm.ComponentModel;

namespace TabbedPagesWithCollectionViewDemo.Models
{
    public partial class SevenDayRainRow : ObservableObject
    {
        public string PivotName { get; set; } = string.Empty;
        public string RainDate1 { get; set; } = DateTime.Today.ToShortDateString();
        public double Rain1 { get; set; }
        public string RainDate2 { get; set; } = DateTime.Today.AddDays(-1).ToShortDateString();
        public double Rain2 { get; set; }
        public string RainDate3 { get; set; } = DateTime.Today.AddDays(-2).ToShortDateString();
        public double Rain3 { get; set; }
        public string RainDate4 { get; set; } = DateTime.Today.AddDays(-3).ToShortDateString();
        public double Rain4 { get; set; }
        public string RainDate5 { get; set; } = DateTime.Today.AddDays(-4).ToShortDateString();
        public double Rain5 { get; set; }
        public string RainDate6 { get; set; } = DateTime.Today.AddDays(-5).ToShortDateString();
        public double Rain6 { get; set; }
        public string RainDate7 { get; set; } = DateTime.Today.AddDays(-6).ToShortDateString();
        public double Rain7 { get; set; }
        public double Total => Rain1 + Rain2 + Rain3 + Rain4 + Rain5 + Rain6 + Rain7;

    }
}
