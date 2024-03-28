namespace TamagotchiCSharpThreading.Screens
{
    public partial class LoadScreen : ContentPage
    {
        public LoadScreen()
        {
            InitializeComponent();
        }

        async void StartGame(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GameScreen());
        }

        async void LoadGame(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GameScreen());
        }
    }
}