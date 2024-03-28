using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Storage;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using Windows.System;
//using static Java.Util.Jar.Attributes;

namespace TamagotchiCSharpThreading.Screens
{
    public partial class CreateNewSaveScreen : ContentPage
    {
        public CreateNewSaveScreen()
        {
            InitializeComponent();
        }
        async void createTamagotchi(object sender, EventArgs args)
        {
            createTamagotchiFile(sender, args);
            new Tamagotchi(entry.Text, "FIRE");
            await Navigation.PushAsync(new GameScreen());
        }


        void createTamagotchiFile(object sender, EventArgs args)
        {
            string nameInput = entry.Text;
            // Generate XML content
            XElement root = new XElement("Root",
                new XElement("Tamagotchi",
                    new XElement("Name", nameInput),
                    new XElement("food", 15),
                    new XElement("sleep", 15),
                    new XElement("attention", 15),
                    new XElement("dead", false),
                    new XElement("id", 1),
                    new XElement("type", "normal")
                ),
                new XElement("data",
                    new XElement("StartDate", DateTime.Now),
                    new XElement("LastPlayed", null),
                    new XElement("TimePlayed", null)
                )
            );

            // Save XML to file
            string filePath = Path.Combine("C:\\Users\\Noize\\OneDrive\\Documenten\\Tamagotchi\\TamagotchiCSharpThreading\\Resources\\Files\\" + "data.xml") ;
            root.Save(filePath);

            Debug.WriteLine("xml file generated");
            Debug.WriteLine("Path to file: " + filePath);
        }
        void updateTamagotchi()
        {
            // Load the XML file
            XDocument doc = XDocument.Load(Path.Combine("C:\\Users\\Noize\\OneDrive\\Documenten\\Tamagotchi\\TamagotchiCSharpThreading\\Resources\\Files\\" + "data.xml"));

            // Find the element to update (for example, a specific person element)
            XElement person = (XElement)doc.Descendants("Tamagotchi");

            if (person != null)
            {
                // Update the element (for example, update the age)
                person.Element("Age").Value = "31";

                // Save the changes to the XML file
                doc.Save("data.xml");

                Debug.WriteLine("XML file updated successfully.");
            }
            else
            {
                Debug.WriteLine("Person not found.");
            }
            Debug.WriteLine("xml file updated");
        }
    }
}