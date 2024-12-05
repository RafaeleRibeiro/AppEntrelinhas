namespace AppEntrelinhas.Pages;

public partial class PaginaInicial : ContentPage
{
    public PaginaInicial()
    {
        InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void Ficcao_Clicked(object sender, EventArgs e)
    {

    }

    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }
}