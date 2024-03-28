using TamagotchiCSharpThreading.Screens;

namespace TamagotchiCSharpThreading
{
    public partial class App : Application
    {
        public static Tamagotchi? SessionData { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
