namespace TabbedPagesWithCollectionViewDemo.Pages;

public partial class IrrigateOpsTabs : TabbedPage
{
	public IrrigateOpsTabs()
	{
		InitializeComponent();

        //this.Children.Add(new IrrigateOpsPlan());
        this.Children.Add(new DailyRainFall());
    }

    private void IrrigateOpsTabs_CurrentPageChanged(object? sender, EventArgs e)
    {
        try
        {
            var index = this.Children.IndexOf(this.CurrentPage);
         
            switch (index)
            {
                case 0:
                    Title = "Yesterday's Readings";
                    break;
                case 1:
                    Title = "Irrigaiton Plan";
                    break;
                case 2:
                    Title = "Today's Readings";
                    break;
                case 3:
                    Title = "Tomorrow's Readings";
                    break;
                case 4:
                    Title = "7 Day Rainfall";
                    break;
                case 5:
                    Title = "Hourly Rain";
                    break;
                default:
                    Title = "Irrigation Logging";
                    break;
            }
            this.InvalidateMeasure();
            this.ForceLayout();
        }
        catch (Exception ex)
        {
          

        }
    }
}