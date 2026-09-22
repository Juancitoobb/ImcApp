using ImcApp.MAUI.Models;
using System.Runtime.CompilerServices;

namespace ImcApp.MAUI.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        LimpiarValores();
	}

    private void OnCalcularButtonClicked(object sender, EventArgs e)
    {
        decimal peso;
        bool pesoEsValido = decimal.TryParse(PesoLabel.Text, out peso);
        decimal estatura;
        bool estaturaEsValida = decimal.TryParse(EstaturaLabel.Text, out estatura);
        if (pesoEsValido && estaturaEsValida)
        {
            decimal imc = CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
            ImcLabel.Text = imc.ToString("F4");
            SituacionNutricionalLabel.Text = CalculadoraDeIndiceDeMasaCorporal.SituacionNutricional(imc);
        }
    }

    private void OnLimpiarButtonClicked(object sender, EventArgs e)
    {
        LimpiarValores();
    }

    private void LimpiarValores()
    {
        PesoLabel.Text = string.Empty;
        EstaturaLabel.Text = string.Empty;
        ImcLabel.Text = string.Empty;
        SituacionNutricionalLabel.Text = string.Empty;
    }
}