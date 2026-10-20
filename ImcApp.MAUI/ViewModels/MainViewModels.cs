using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImcApp.MAUI.Models;

namespace ImcApp.MAUI.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        private string _peso;
        [ObservableProperty]
        private string _imc;
        [ObservableProperty]
        private string _estatura;
        [ObservableProperty]
        private string _situacionNutricional;
        public MainViewModels()
        {
            Limpiar();
        }

        [RelayCommand]
        private void Limpiar()
        {
            Peso = string.Empty;
            Estatura = string.Empty;
            Imc = string.Empty;
            SituacionNutricional = string.Empty;
        }

        [RelayCommand]
        public void Calcular()
        {
            decimal peso;
            bool pesoEsValido = decimal.TryParse(Peso, out peso);
            decimal estatura;
            bool estaturaEsValida = decimal.TryParse(Estatura, out estatura);
            if (pesoEsValido && estaturaEsValida)
            {
                decimal imc = CalculadoraDeIndiceDeMasaCorporal.IndiceDeMasaCorporal(peso, estatura);
                Imc = imc.ToString("F4");
                SituacionNutricional = CalculadoraDeIndiceDeMasaCorporal.SituacionNutricional(imc);
            }
        }
    }
}
