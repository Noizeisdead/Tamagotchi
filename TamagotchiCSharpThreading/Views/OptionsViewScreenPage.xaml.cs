namespace TamagotchiCSharpThreading.Views
{
    public partial class OptionsViewScreenPage : ContentPage
    {

        // The value we want the slider to increment each time it updates
        readonly double sliderIncrement = 5;

        // The value for the slider we will be using.
        double sliderCorrectValue;

        public OptionsViewScreenPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            // Recognize the sender as a Slider object.
            Slider slider = (Slider)sender;

            // Get the slider value relative to the minimum,
            // needed to calculate valid values with increment.
            double relativeValue = Math.Round(slider.Value - slider.Minimum, 0);

            // Check if the value is valid, based on our increment.
            if (relativeValue % sliderIncrement == 0)
            {
                // Value is valid
                sliderCorrectValue = slider.Value;

                // Update label text (optional)
                // displayLabelMasterVolume.Text = sliderCorrectValue.ToString();
            }
            else
            {
                if (((relativeValue) % sliderIncrement) < 2)
                {
                    sliderCorrectValue = relativeValue + ((relativeValue) % sliderIncrement);
                }
                else
                {
                    sliderCorrectValue = relativeValue - ((relativeValue) % sliderIncrement);
                }

                slider.Value = sliderCorrectValue;
                //displayLabelMasterVolume.Text = sliderCorrectValue.ToString();
            }



            //double value = args.NewValue;
            //displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }
}
