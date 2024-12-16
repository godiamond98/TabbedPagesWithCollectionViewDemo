using TabbedPagesWithCollectionViewDemo.Models;
using TabbedPagesWithCollectionViewDemo.ViewModels;

namespace TabbedPagesWithCollectionViewDemo.Pages;

public partial class DailyRainFall : ContentPage
{
	public DailyRainFall()
	{
		InitializeComponent();
        BindingContext = new DailyRainViewModel();
	}




    private void TechnicianComboBox_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
    {
        if (BindingContext is DailyRainViewModel vm)
        {
            if (e.AddedItems != null && vm.InitialLoad == false)
            {
                var item = e.AddedItems.FirstOrDefault() as DropdownItem;
                if (item != null)
                {
                    var id = item.Id;
                    Preferences.Set("SelectedOperatorId", id);
                    vm.LoadRainFallDataCommand.Execute(null);
                    DailyRainGrid.ScrollToRowColumnIndex(0, 0);
                }
            }
        }
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        if (BindingContext is DailyRainViewModel vm && vm.Technicians != null)
        {
            await Task.Delay(1000);
            vm.LoadRainFallDataCommand.Execute(null);
        }
    }
}