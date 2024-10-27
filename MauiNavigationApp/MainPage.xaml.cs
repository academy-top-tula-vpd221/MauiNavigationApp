namespace MauiNavigationApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            Title = "Main Page";
        }

        private async void btnToOrdinal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrdinalPage(), true);
        }

        private async void btnToModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ModalPage(), true);
        }
    }

}
