using AppEntrelinhas.Pages;

namespace AppEntrelinhas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaInicial());
        }
    }
}
