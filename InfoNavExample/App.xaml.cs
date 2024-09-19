namespace InfoNavExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            // Set MainPage with Navigation capabilities
           //MainPage = new NavigationPage(new MainPage());
        }
    }
}
