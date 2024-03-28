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

        void FeedButtonPress(object sender, EventArgs args)
        {

            int foodValue = App.SessionData.GetFoodLevel();

            App.SessionData.SetFoodLevel(foodValue++);

            Console.WriteLine(foodValue);

        }

        void SleepButtonPress(object sender, EventArgs args)
        {

            int sleepValue = App.SessionData.GetSleepLevel();

            App.SessionData.SetSleepLevel(sleepValue++);

            Console.WriteLine(sleepValue);
        }
    }
}