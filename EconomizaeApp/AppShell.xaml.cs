using EconomizaeApp.MVVM.Views;

namespace EconomizaeApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(ResultadoView), typeof(ResultadoView));
    }
}
