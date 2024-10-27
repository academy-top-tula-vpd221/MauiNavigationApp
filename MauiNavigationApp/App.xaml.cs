namespace MauiNavigationApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackground = Colors.DarkRed,
                BarTextColor = Colors.White
            }; //new AppShell();
        }
    }
}
