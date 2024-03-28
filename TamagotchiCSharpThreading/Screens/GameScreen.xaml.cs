namespace TamagotchiCSharpThreading.Screens
{
    public partial class GameScreen : ContentPage
    {
        public GameScreen()
        {
            InitializeComponent();
        }

        void LeftButtonPress(object sender, EventArgs args)
        {

        }
        async void ActionButtonPress(object sender, EventArgs args) 
        {
            await Navigation.PushAsync(new ActionScreen());
        }



        void RightButtonPress(object sender, EventArgs args) 
        {

        }

        async void OptionsButtonPress(object sender, EventArgs args) 
        {
            await Navigation.PushAsync(new OptionsScreen());
        }



    }
}
