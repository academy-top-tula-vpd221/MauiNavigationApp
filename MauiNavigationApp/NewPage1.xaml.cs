
namespace MauiNavigationApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

        Title = "Page 2";
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        string stackText = "";

        var navPage = Application.Current?.MainPage;
        var ordinalPage = navPage.Navigation.NavigationStack[1];
        navPage.Navigation.InsertPageBefore(new NewPage2(), ordinalPage);

        foreach (Page p in navPage.Navigation.NavigationStack)
            stackText += $"Page: {p.Title}\n";

        labelStack.Text = stackText;
    }

    protected override void OnDisappearing()
    {

    }
}