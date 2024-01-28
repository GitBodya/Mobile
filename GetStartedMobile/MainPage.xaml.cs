using GetStartedMobile.Views;

namespace GetStartedMobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                #region Old links
                //await Navigation.PushAsync(new HelloXamlPage());
                //await Navigation.PushAsync(new MarkupExt());
                //await Navigation.PushAsync(new StaticConstantsPage());
                //await Navigation.PushAsync(new Views.SliderBindingsPage());
                //await Navigation.PushAsync(new Views.SliderTransformsPage());
                //await Navigation.PushAsync(new Views.ListViewDemoPage());
                //await Navigation.PushAsync(new Views.OneShotDateTimePage());
                //await Navigation.PushAsync(new Views.ClockPage());
                //await Navigation.PushAsync(new Views.HslColorScrollPage());
                //await Navigation.PushAsync(new Views.KeypadPage());
                //await Navigation.PushAsync(new Views.StaticDemoPage());
                // await Navigation.PushAsync(new Views.ReferenceDemoPage());
                //await Navigation.PushAsync(new Views.TypeDemoPage());
                //await Navigation.PushAsync(new Views.ArrayDemoPage());
                //await Navigation.PushAsync(new Views.NullDemoPage());
                //await Navigation.PushAsync(new Views.HslColorDemoPage());
                //await Navigation.PushAsync(new Views.BasicCodeBindingPage());
                #endregion
                //await Navigation.PushAsync(new Views.BasicXamlBindingPage());
                //await Navigation.PushAsync(new Views.AlternativeCodeBindingPage());
                await Navigation.PushAsync(new Views.AlternativeXamlBindingPage());
                




            };

            Content = button;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
