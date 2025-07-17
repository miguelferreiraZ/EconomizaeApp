namespace EconomizaeApp.MVVM.Views;

public partial class EconomizaeView : ContentPage
{
	public EconomizaeView()
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
    }
    private void OnCalcularClicked(object sender, EventArgs e)
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

            valorCalculadoLabel.Text = $"R$ {economia:F2}";
            resultadoFrame.IsVisible = true;
        }
        else
        {
            DisplayAlert("Erro", "Preencha todos os campos corretamente.", "OK");
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}