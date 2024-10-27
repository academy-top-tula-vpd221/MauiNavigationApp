namespace MauiNavigationApp;

public partial class OrdinalPage : ContentPage
{
	public OrdinalPage()
	{
		InitializeComponent();

		Title = "Ordinal Page";
	}

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

    private async void btnToPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPage(new NewPage1()));
    }
}