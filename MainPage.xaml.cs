using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.Input;

namespace ToolBarItemBadge;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    [RelayCommand]
    private async Task Filter()
    {
        await Toast.Make("Filter").Show();
    }

    [RelayCommand]
    private async Task Settings()
    {
        await Toast.Make("Settings").Show();
    }

    [RelayCommand]
    private async Task Profile()
    {
        await Toast.Make("Profile").Show();
    }

    [RelayCommand]
    private async Task Logout()
    {
        await Toast.Make("Logout").Show();
    }
}