using CommunityToolkit.Maui;
using IconTintColorBehaviorBug.Services;
using Microsoft.Extensions.Logging;

namespace IconTintColorBehaviorBug;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MainPage, MainPageViewModel>();
        builder.Services.AddSingleton<ThemePage, ThemePageViewModel>();
        builder.Services.AddTransient<SubPage, SubPageViewModel>();
        
        builder.Services.AddSingleton<INavigationService, NavigationService>();

        builder.Services.AddHttpClient("ApiClient")
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://rickandmortyapi.com/api/"));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}