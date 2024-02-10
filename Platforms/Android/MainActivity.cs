using Android.App;
using Android.Content.PM;
using Microsoft.Maui.Handlers;

namespace ToolBarItemBadge;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public MainActivity()
    {
        ToolbarHandler.Mapper.AppendToMapping("CustomNavigationView", (handler, view) =>
        {
            handler.PlatformView.ContentInsetStartWithNavigation = 0;
            handler.PlatformView.SetContentInsetsAbsolute(0, 0);
        });
    }
}