using Android.Graphics;
using AndroidX.ConstraintLayout.Core.Motion.Utils;
using System.Diagnostics;

namespace MaquinaEnvejecimiento.Views;

public partial class MeasurementsPage : ContentPage
{
    public MeasurementsPage()
    {
        InitializeComponent();
    }

    private async void BackButton(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync(true);
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
           float num = float.Parse(e.NewTextValue);
            Cicles.TextColor = num % 2 == 0 ? Colors.Black : Colors.Red;   
        }catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
        }
    }
}