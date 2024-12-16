using TabbedPagesWithCollectionViewDemo.Pages;

namespace TabbedPagesWithCollectionViewDemo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(IrrigateOpsTabs), typeof(IrrigateOpsTabs));
        }
    }
}
