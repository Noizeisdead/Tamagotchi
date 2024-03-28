using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TamagotchiCSharpThreading
{
    internal class File
    {

        public void createTamagotchiFile()
        {
            // Generate XML content
            XElement root = new XElement("Root",
                new XElement("Tamagotchi",
                    new XElement("Name", "John"),
                    new XElement("food", 15),
                    new XElement("sleep", 15 )
                )
            );

            // Save XML to file
            root.Save("data.xml");

            // Display success message
            Label successLabel = new Label
            {
                Text = "XML file generated successfully!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Console.WriteLine( successLabel );

        }

    }
}
