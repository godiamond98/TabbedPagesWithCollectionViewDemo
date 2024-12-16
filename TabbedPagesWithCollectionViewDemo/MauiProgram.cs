using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using TabbedPagesWithCollectionViewDemo.Pages;
using TabbedPagesWithCollectionViewDemo.ViewModels;

namespace TabbedPagesWithCollectionViewDemo
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .UseMauiCommunityToolkit()
                .RegisterServices()
                .RegisterViewModels()
                .RegisterPages()
                .ConfigureMyFonts();


            return builder.Build();            
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            //irriagtion
            builder.Services.AddTransient<IrrigateOpsPlanViewModel>();


            return builder;
        }

        public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
        {

            builder.Services.AddSingleton<AppShell>();

            //irrigation
            builder.Services.AddTransient<IrrigateOpsTabs>();




            return builder;
        }

        //services
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            try
            {
#if DEBUG
                builder.Logging.AddDebug();
#endif
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
            return builder;
        }

        public static MauiAppBuilder ConfigureMyFonts(this MauiAppBuilder builder)
        {
            builder.ConfigureFonts(fonts =>
            {
                fonts.AddFont("fa-regular-400.ttf", "FAR");
                fonts.AddFont("fa-solid-900.ttf", "FAS");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
            return builder;
        }
    }
}
