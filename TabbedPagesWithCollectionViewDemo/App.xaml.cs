using Syncfusion.Licensing;

namespace TabbedPagesWithCollectionViewDemo
{
    public partial class App : Application
    {
        public App()
        {
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF5cWWtCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWH5ccHVURGJcVkB3X0I=");

            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
