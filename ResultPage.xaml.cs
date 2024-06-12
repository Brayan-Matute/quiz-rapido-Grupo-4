namespace CalculadoraMAUI
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double resultado)
        {
            InitializeComponent();
            ResultadoLabel.Text = $"El resultado es: {resultado}";
        }

        private async void OnRegresarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
