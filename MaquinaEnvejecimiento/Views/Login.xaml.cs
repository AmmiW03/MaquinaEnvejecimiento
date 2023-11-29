namespace MaquinaEnvejecimiento.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void SignInClicked(object sender, EventArgs e)
    {
        bool flag = true;
        if (flag)
        {
            await SecureStorage.Default.SetAsync("isLogged", "1");
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error al Iniciar Sesion", "No se pudo iniciar sesion verifique que los datos esten escritos correctamente", "OK");
        }
    }

    private async void OnLabelTapped(object sender, EventArgs args)
    {
        await Navigation.PushAsync(new SignupPage(), true);
    }



}