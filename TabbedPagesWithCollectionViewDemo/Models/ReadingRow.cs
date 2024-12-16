using CommunityToolkit.Mvvm.ComponentModel;

namespace TabbedPagesWithCollectionViewDemo.Models
{
    public partial class ReadingRow : ObservableObject
    {

        [ObservableProperty]
        private string id = string.Empty;
        
        [ObservableProperty]
        private int myPivot;

        [NotifyPropertyChangedFor(nameof(HomePositionEnabled))]
        [ObservableProperty]
        private DateTime readingDate;
        
        [ObservableProperty]
        private string? technician;
        
        [ObservableProperty]
        private string? pivotName; 
               
        [ObservableProperty]                
        private int homePosition;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(StartTimeLabel))]
        private DateTime startTime;

        [ObservableProperty]
        private double rain;

        [NotifyPropertyChangedFor(nameof(CancelButtonIsVisible))]
        [ObservableProperty]
        private double _irrigation;

        [ObservableProperty]
        private bool cancelStart;
        

        public string StartTimeLabel => StartTime.ToString("HH:mm");
        
        public bool HomePositionEnabled => ReadingDate.Date >= DateTime.Today.Date;
              
        public bool CancelButtonIsVisible => Irrigation > 0;
        
    }
}
