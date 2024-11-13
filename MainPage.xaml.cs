namespace BindableProperty_validation;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void TestButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            // This should throw an ArgumentException according to docs
            // but it doesn't when the validator returns false
            CustomControl.CustomText = string.Empty;
            Console.WriteLine("No exception was thrown!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Expected exception: {ex.Message}");
        }
    }
}
