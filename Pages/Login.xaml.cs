namespace AppEntrelinhas.Pages;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();

        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void submit_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }
}