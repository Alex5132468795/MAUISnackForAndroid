using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Microsoft.Maui.Graphics.Text;

namespace MauiApp19;

public partial class MainPage : ContentPage
{
	int number = 0;
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		CancellationToken c = new CancellationToken();
		Snackbar s = new Snackbar();
		SnackbarOptions SsnackbarOptions = new SnackbarOptions()
		{
			BackgroundColor = Color.FromRgb(255, 0, 0),
            TextColor = Color.FromRgb(255, 255, 0)
        };
		s = (Snackbar)Snackbar.Make("OWO", async () => await DisplayAlert("Welcom", "be-bei see you", "Okey"), "UWU", TimeSpan.FromSeconds(10),SsnackbarOptions);
		Snackbar q = new Snackbar();
        SnackbarOptions QsnackbarOptions = new SnackbarOptions()
        {
            BackgroundColor = Color.FromRgb(0, 0, 0),
            TextColor = Color.FromRgb(0, 0, 255)
        };
        q = (Snackbar)Snackbar.Make("Quit", async () => await DisplayAlert("Welcom xenos", "Contingation see you", "Accept"), "Sure", TimeSpan.FromSeconds(10), QsnackbarOptions);
        Snackbar es = new Snackbar();
        SnackbarOptions EssnackbarOptions = new SnackbarOptions()
        {
            BackgroundColor = Color.FromRgb(10, 10, 10),
            TextColor = Color.FromRgb(0, 0, 255)
        };
        es = (Snackbar)Snackbar.Make("Help", async () => await DisplayAlert("Buy Skyrim", "Buy Skyrim", "Buy"), "Yes", TimeSpan.FromSeconds(10), EssnackbarOptions);
		switch (number)
		{
			case 0:
				s.Show();
				number++;
				break;
			case 1:
				q.Show();
				number++;
				break;
			case 2:
				es.Show();
				number = 0;
				break;
		}
	}
}

