namespace MauiNavigationApp;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();

		Title = "Modal Page";
	}

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}