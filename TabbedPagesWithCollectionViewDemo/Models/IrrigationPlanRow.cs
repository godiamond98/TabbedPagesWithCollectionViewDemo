
namespace TabbedPagesWithCollectionViewDemo.Models
{
    public partial class IrrigationPlanRow
    {
        public string Field { get; set; } = string.Empty;
        public DateTime IrrigationDate { get; set; }
        public double MinApp { get; set; }
        public double HalfTime { get; set; }
        public string Control { get; set; } = string.Empty;
        public double? HomePos { get; set; }
        public bool LAFS { get; set; }
        public int IsPrimary { get; set; }
        public double? Depth { get; set; }
        public string Notes { get; set; } = string.Empty;
        public string StartTimeLabel { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public Color NoteColor
        {
            get
            {
                if (Notes.Length > 0 && Notes[0] == '*')
                {
                    Notes = Notes.Substring(1);
                    return App.Current?.RequestedTheme == AppTheme.Dark ? Colors.Green : Colors.LightGreen;
                }
                else if (Notes.Length > 0 && Notes == "0")
                {
                    Notes = "No Instructions";
                    return App.Current?.RequestedTheme == AppTheme.Dark ? Colors.White : Colors.Black;
                }
                else
                {
                    return App.Current?.RequestedTheme == AppTheme.Dark ? Colors.White : Colors.Black;
                }
            }
        }
        public Color MyColor
        {
            get
            {
                if (IsPrimary == 1)
                {
                    return App.Current?.RequestedTheme == AppTheme.Dark ? Colors.Black : Colors.White;
                }
                else
                {
                    return App.Current?.RequestedTheme == AppTheme.Dark ? Colors.Gray : Color.FromArgb("#e6eaf7");
                }
            }

        }
    }
}
