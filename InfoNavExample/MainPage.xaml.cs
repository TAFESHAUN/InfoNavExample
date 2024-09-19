namespace InfoNavExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            // Get the user input from the Entry field
            string userInfo = userEntry.Text;

            Product product = new Product();
            product.Id = 1;
            product.Name = userInfo;

            // Pass the user information to the DetailsPage
            //await Navigation.PushAsync(new DetailsPage(userInfo));
            await Navigation.PushAsync(new DetailsPage(userInfo, product));
        }
    }

}
