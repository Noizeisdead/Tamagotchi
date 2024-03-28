namespace TamagotchiCSharpThreading.Screens
{
    public partial class ActionScreen : ContentPage
    {
        public ActionScreen()
        {
            InitializeComponent();
        }
        async void OptionsButtonPress(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new OptionsScreen());
        }
    }
}