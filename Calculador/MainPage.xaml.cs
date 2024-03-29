namespace Calculador
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void zerar_Clicked(object sender, EventArgs e)
        {

        }

        private void maismenos_Clicked(object sender, EventArgs e)
        {

        }

        private void porcento_Clicked(object sender, EventArgs e)
        {

        }

        private void dividir_Clicked(object sender, EventArgs e)
        {

        }

        private void num7_Clicked(object sender, EventArgs e)
        {

        }

        private void num9_Clicked(object sender, EventArgs e)
        {

        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {

        }

        private void subtrair_Clicked(object sender, EventArgs e)
        {

        }

        private void num1_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num2_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num3_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void somar_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void num0_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void ponto_Clicked(System.Object sender, System.EventArgs e)
        {

        }

        private void igual_Clicked(System.Object sender, System.EventArgs e)
        {

        }
    }

}
