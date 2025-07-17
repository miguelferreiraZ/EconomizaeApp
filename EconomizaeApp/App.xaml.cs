using EconomizaeApp.MVVM.Views;

namespace EconomizaeApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}