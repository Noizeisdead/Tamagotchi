namespace TamagotchiCSharpThreading.Screens
{
    public partial class MenuScreen : ContentPage
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        async void GotoNewSave(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CreateNewSaveScreen());
        }

        async void GotoLoadSave(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LoadScreen());
        }

        async void GotoOptions(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new OptionsScreen());
        }

        void CloseApplication(object sender, EventArgs args) 
        {
            Application.Current.Quit();
        }
    }
}