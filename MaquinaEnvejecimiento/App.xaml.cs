using MaquinaEnvejecimiento.Views;

namespace MaquinaEnvejecimiento;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        var isLoogged = SecureStorage.GetAsync("isLogged").Result;
        if (isLoogged == "1")
		{
        MainPage = new AppShell();
        }
		else
		{
			MainPage = new NavigationPage(new LoginPage());
		}
    }
}
