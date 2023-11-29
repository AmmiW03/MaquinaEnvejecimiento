using MaquinaEnvejecimiento.Views;

namespace MaquinaEnvejecimiento;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    private async void OnLogout(object sender, EventArgs e)
    {
        await SecureStorage.SetAsync("isLogged", "0");
        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }
}
