using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CommunityToolkit.Maui.Core.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TabbedPagesWithCollectionViewDemo.Models;

namespace TabbedPagesWithCollectionViewDemo.ViewModels
{
    public partial class DailyRainViewModel : ObservableObject
    {


        public DailyRainViewModel()
        {
            Technicians = [];
            RainDataCollection = [];
            InitialLoad = true;
            LoadTechnicianComboBox();         
            SelectedDate = DateTime.Today;
            SetDates();
        }

        #region functions

        private void LoadTechnicianComboBox()
        {
            Technicians = [];
            Technicians.Add(new DropdownItem { Id = -1, Text = "Select Technician" });
            Technicians.Add(new DropdownItem { Id = 1, Text = "John Doe" });
            SelectedTechnician = Technicians.FirstOrDefault();
        }


        public void SetDates()
        {
            DateTime date = Preferences.Get("IrrigationDate", DateTime.Today);
            Date1 = date;
            Date2 = date.AddDays(-1);
            Date3 = date.AddDays(-2);
            Date4 = date.AddDays(-3);
            Date5 = date.AddDays(-4);
            Date6 = date.AddDays(-5);
            Date7 = date.AddDays(-6);
        }

        [RelayCommand]
        public async Task LoadRainFallData()
        {
            try
            {

                if (IsLoading) { return; }
                
                IsLoading = true;

                RainDataCollection = [];

                await Task.Delay(200);

                var r = new System.Random();


                //this would be an async call to the web api
                List<SevenDayRainRow> rain = [];
                for (int i = 0; i < 20; i++)
                {                   
                    var today = SelectedDate;
                    rain.Add(new SevenDayRainRow
                    {
                        PivotName = $"B-{i}",
                        Rain1 = r.NextDouble(), 
                        RainDate1 = today.ToString(),
                        Rain2 = r.NextDouble(),
                        RainDate2 = today.AddDays(-1).ToString(),
                        Rain3 = r.NextDouble(),
                        RainDate3 = today.AddDays(-2).ToString(),
                        Rain4 = r.NextDouble(),
                        RainDate4 = today.AddDays(-3).ToString(),
                        Rain5 = r.NextDouble(),
                        RainDate5 = today.AddDays(-4).ToString(),
                        Rain6 = r.NextDouble(),
                        RainDate6 = today.AddDays(-5).ToString(),
                        Rain7 = r.NextDouble(),
                        RainDate7 = today.AddDays(-6).ToString()
                        
                    });
                }

                AppShell.Current.Dispatcher.Dispatch(() =>
                {
                    RainDataCollection = rain.ToObservableCollection();
                });
            }
            catch 
            {

            }
            finally
            {
                IsLoading = false;
                InitialLoad = false;
            }
        }
        #endregion

        #region properties

        [ObservableProperty]
        private DateTime selectedDate;

        [ObservableProperty]
        private ObservableCollection<SevenDayRainRow> rainDataCollection;

        [ObservableProperty]
        private ObservableCollection<DropdownItem> technicians;

        [ObservableProperty]
        private DropdownItem? selectedTechnician;

        [ObservableProperty]
        private DateTime date1;

        [ObservableProperty]
        private DateTime date2;

        [ObservableProperty]
        private DateTime date3;

        [ObservableProperty]
        private DateTime date4;

        [ObservableProperty]
        private DateTime date5;

        [ObservableProperty]
        private DateTime date6;

        [ObservableProperty]
        private DateTime date7;

        [ObservableProperty]
        private bool isLoading;

        [ObservableProperty]
        private bool initialLoad;
        #endregion

    }
}
