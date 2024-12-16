namespace TabbedPagesWithCollectionViewDemo.Models
{
    public class IrrigationPlan
    {
        public string DailyMessage { get; set; } = string.Empty;
        public List<IrrigationPlanRow> Pivots { get; set; } = [];
    }
}
