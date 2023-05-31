namespace NumbersBetweenApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //method for the code that will be executed when the button is clicked.
        private void ShowNumbersButton_Clicked(object sender, EventArgs e)
        {
            /*to convert the text entered in the startNumberEntry Entry control
            into an integer and storing it in the startNumber variable.*/
            int startNumber = Convert.ToInt32(startNumberEntry.Text);

            /*converts the text entered in the endNumberEntry Entry control into 
              integer and stores it in the endNumber variable.*/
            int endNumber = Convert.ToInt32(endNumberEntry.Text);

                                //converts the specified value to a 32-bit signed integer.
            int incrementValue = Convert.ToInt32(incrementEntry.Text);

            if (startNumber > endNumber)
            {
                DisplayAlert("Error", "Start number should be less than end number.", "OK");
                return;
            }

            for (int i = startNumber; i <= endNumber; i += incrementValue)
            {
                numberLabel.Text += $"{i} ";
            }
        }
    }
}
