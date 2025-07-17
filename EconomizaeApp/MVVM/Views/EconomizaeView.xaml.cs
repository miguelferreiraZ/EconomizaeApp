namespace EconomizaeApp.MVVM.Views;

public partial class EconomizaeView : ContentPage
{
	public EconomizaeView()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    private async void OnCalcularClicked(object sender, EventArgs e)
    {
        if (double.TryParse(valorEntry.Text, out double valorCompra) &&
            estadoPicker.SelectedItem is string estado)
        {
            double percentual = estado switch
            {
                "SP" => 0.07,
                "RJ" => 0.02,
                "MG" => 0.015,
                "ES" => 0.02,
                _ => 0.01
            };

            double economia = valorCompra * percentual;

            Preferences.Default.Set("Economia", economia);
            Preferences.Default.Set("EstadoSelecionado", estado);

            await Shell.Current.GoToAsync(nameof(ResultadoView));
        }
        else
        {
            await DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
        }
    }
}