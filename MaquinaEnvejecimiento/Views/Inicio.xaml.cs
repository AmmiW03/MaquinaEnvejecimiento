namespace MaquinaEnvejecimiento.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private async void MeasurementsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MedicionesPage");
    }

    private async void AddMeasurementsClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MeasurementsPage(),true);
    }
}