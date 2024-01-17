namespace WeatherApp;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

	private void BtnGetStarted_Clicked(object sender, Eventargs e)
	{
		Navigation.PushModalAsync(new WeatherPage());
	}

}