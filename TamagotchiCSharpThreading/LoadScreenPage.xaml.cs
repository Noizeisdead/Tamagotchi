using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiCSharpThreading
{
    public partial class LoadScreenPage : ContentPage
    {
        int count = 0;

        public LoadScreenPage()
        {
            InitializeComponent();
        }

        /*private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }*/
    }
}
