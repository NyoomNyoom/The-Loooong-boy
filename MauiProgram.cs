using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Loooong_boy.ViewModels;

namespace Loooong_boy;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit().UseMauiCommunityToolkitMediaElement();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<GameScreen>();
        builder.Services.AddTransient<GameScreenModel>();

        return builder.Build();
    }
}