namespace BindableProperty_validation
{
    public class CustomControl : ContentView
    {
        public static readonly BindableProperty CustomTextProperty = BindableProperty.Create(
            nameof(CustomText),
            typeof(string),
            typeof(CustomControl),
            defaultValue: string.Empty,
            validateValue: (bindable, value) =>
            {
                // This validator returns false for empty strings
                // We expect this to throw an ArgumentException, but it doesn't
                return !string.IsNullOrEmpty((string)value);
            }
        );

        public string CustomText
        {
            get => (string)GetValue(CustomTextProperty);
            set => SetValue(CustomTextProperty, value);
        }

        public CustomControl()
        {
            // Basic layout for demonstration
            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            CustomText = "some valid text";

            // Set up the binding correctly
            ((Label)Content).SetBinding(Label.TextProperty, new Binding(nameof(CustomText), source: this));
        }
    }
}
