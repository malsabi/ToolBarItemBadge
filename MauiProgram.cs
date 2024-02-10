using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using UraniumUI;

namespace ToolBarItemBadge
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddMaterialIconFonts();
            })
            .UseUraniumUI()
            .UseUraniumUIMaterial()
            .UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}