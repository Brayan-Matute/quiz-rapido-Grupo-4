namespace CalculadoraMAUI
{
    public partial class MainPage : ContentPage
    {
        OperacionesMatematicas operaciones = new OperacionesMatematicas();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSumaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double numero1) && double.TryParse(Numero2Entry.Text, out double numero2))
            {
                double resultado = operaciones.Suma(numero1, numero2);
                await Navigation.PushAsync(new ResultPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese números válidos.", "OK");
            }
        }

        private async void OnRestaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double numero1) && double.TryParse(Numero2Entry.Text, out double numero2))
            {
                double resultado = operaciones.Resta(numero1, numero2);
                await Navigation.PushAsync(new ResultPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese números válidos.", "OK");
            }
        }

        private async void OnDivisionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double numero1) && double.TryParse(Numero2Entry.Text, out double numero2))
            {
                try
                {
                    double resultado = operaciones.Division(numero1, numero2);
                    await Navigation.PushAsync(new ResultPage(resultado));
                }
                catch (DivideByZeroException ex)
                {
                    await DisplayAlert("Error", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese números válidos.", "OK");
            }
        }

        private async void OnMultiplicacionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(Numero1Entry.Text, out double numero1) && double.TryParse(Numero2Entry.Text, out double numero2))
            {
                double resultado = operaciones.Multiplicacion(numero1, numero2);
                await Navigation.PushAsync(new ResultPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese números válidos.", "OK");
            }
        }
    }
}
