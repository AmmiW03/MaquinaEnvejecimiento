namespace MaquinaEnvejecimiento.Views;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void RegisterClicked(object sender, EventArgs e)
    {
        await SecureStorage.Default.SetAsync("isLogged", "1");
        await Navigation.PopAsync(true);
        Application.Current.MainPage = new AppShell();
        await Shell.Current.GoToAsync("//InicioPage");
    }
}