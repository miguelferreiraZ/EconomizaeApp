namespace EconomizaeApp.MVVM.Views;

public partial class ResultadoView : ContentPage
{
    public ResultadoView()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        double economia = Preferences.Default.Get("Economia", 0.0);
        valorCalculadoLabel.Text = $"R$ {economia:F2}";
    }

    private async void OnAbrirSiteClicked(object sender, EventArgs e)
    {
        string estado = Preferences.Default.Get("EstadoSelecionado", "SP");

        string url = estado switch
        {
            "SP" => "https://www.nfp.fazenda.sp.gov.br",
            "RJ" => "https://notacarioca.rio.gov.br",
            "MG" => "https://notafiscalmineira.fazenda.mg.gov.br/",
            "ES" => "https://www.notapremiadacapixaba.es.gov.br/",
            _ => "https://www.nfp.fazenda.sp.gov.br"
        };

        await Launcher.Default.OpenAsync(url);
    }
}
