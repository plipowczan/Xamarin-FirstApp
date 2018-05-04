#region usings

using Xamarin.Forms;

#endregion

namespace Xamarin_FirstApp
{
    public partial class App : Application
    {
        #region Constructors

        public App()
        {
            this.InitializeComponent();

            //this.MainPage = new MainPage();
            // The root page of your application
            var layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcome to Xamarin Forms!"
                    }
                }
            };

            this.MainPage = new ContentPage
            {
                Content = layout
            };

            Button button = new Button
            {
                Text = "Click Me"
            };
            button.Clicked += async (s, e) => { await this.MainPage.DisplayAlert("Alert", "You clicked me", "OK"); };

            layout.Children.Add(button);
        }

        #endregion

        #region Public methods

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        #endregion
    }
}