using System.Diagnostics;
using System.Xml.Linq;

namespace TamagotchiCSharpThreading.Screens
{
    public partial class GameScreen : ContentPage
    {

        private Timer timer;

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

        XElement GetTamagotchiFile()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string projectRootDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.Parent.Parent.FullName;

            // Navigate to the desired directory from the base directory
            string directoryPath = Path.Combine(projectRootDirectory, "Resources", "Files");

            // Load the XML file
            XDocument doc = XDocument.Load(Path.Combine(directoryPath + "\\data.xml"));

            // Find the element to update (for example, a specific person element)
            XElement tomogatchi = doc.Descendants("Tamagotchi").FirstOrDefault();

            return tomogatchi;
        }

        Tamagotchi GetCurrentTamagotchi()
        {
            if (GetTamagotchiFile() != null)
            {
                App.SessionData = new Tamagotchi(GetTamagotchiFile().Element("Name").Value, GetTamagotchiFile().Element("type").Value);
            }
            else
            {
                Debug.WriteLine("Person not found.");
            }
            Debug.WriteLine("xml file updated");

            return App.SessionData;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GetCurrentTamagotchi();

            StartTimer();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            StopTimer();
        }

        private void StartTimer()
        {
            timer = new Timer(UpdateValue, null, TimeSpan.Zero, TimeSpan.FromMinutes(2));
        }

        private void StopTimer()
        {
            timer?.Dispose();
        }

        private void UpdateValue(object state)
        {

            int foodValue = GetCurrentTamagotchi().GetFoodLevel();
            GetCurrentTamagotchi().SetFoodLevel(foodValue--);

            int ageValue = GetCurrentTamagotchi().GetAge();
            GetCurrentTamagotchi().SetAge(ageValue++);

            int sleepValue = GetCurrentTamagotchi().GetSleepLevel();
            GetCurrentTamagotchi().SetSleepLevel(sleepValue--);

            int attentionValue = GetCurrentTamagotchi().GetAttentionLevel();
            GetCurrentTamagotchi().SetAttentionLevel(attentionValue--);

        }

    }
}
