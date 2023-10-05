using BirdCalls.MVVM.ViewModels;
using BirdCalls.MVVM.Views;
using BirdCalls.Services;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace BirdCalls;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()

            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();

		builder.Services.AddSingleton<BirdsHomePage>();
        builder.Services.AddSingleton<BirdsViewModel>();
		builder.Services.AddSingleton<BirdService>();
        builder.Services.AddTransient<BirdsDetailPage>();
        builder.Services.AddTransient<BirdsDetailViewModel>();

#endif

        return builder.Build();
	}
}
