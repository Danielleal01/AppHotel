using AppHotel.Models;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descrição = "Suíte Super Luxo",
                ValorDiáriaAdulto = 110.00,
                ValorDiáriaCriança = 50.00
            },

            new Quarto()
            {
                Descrição = "Suíte Super",
                ValorDiáriaAdulto = 80.00,
                ValorDiáriaCriança = 40.00
            },

            new Quarto()
            {
                Descrição = "Suíte Single",
                ValorDiáriaAdulto = 50.00,
                ValorDiáriaCriança = 25.00
            },

            new Quarto()
            {
                Descrição = "Suíte Crise",
                ValorDiáriaAdulto = 25.00,
                ValorDiáriaCriança = 12.50
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContrataçãoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
