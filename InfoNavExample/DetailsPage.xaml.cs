namespace InfoNavExample;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(string userInfo, Product passProduct)
    {
        InitializeComponent();

        // Display the passed user information on the Label
        userInfoLabel.Text = $"Welcome, {userInfo}!";
        
        //Dispaly the object information passed
        userProductId.Text = Convert.ToString(passProduct.Id);
        userProductName.Text = passProduct.Name;
    }
}