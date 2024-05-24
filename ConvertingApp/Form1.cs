namespace ConvertingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (kgToGramsRadioButton.Checked)
            {
                ConvertKgToGrams();
            }
            else if (gramsToKgRadioButton.Checked)
            {
                ConvertGramsToKg();
            }
            else if (cmToMetersRadioButton.Checked)
            {
                ConvertCmToMeters();
            }
            else if (metersToCmRadioButton.Checked)
            {
                ConvertMetersToCm();
            }
        }

        private void ConvertKgToGrams()
        {
            if (double.TryParse(inputTextBox.Text, out double kg))
            {
                double grams = kg * 1000;
                resultLabel.Text = $"{grams} grams";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for kilograms.");
            }
        }

        private void ConvertGramsToKg()
        {
            if (double.TryParse(inputTextBox.Text, out double grams))
            {
                double kg = grams / 1000;
                resultLabel.Text = $"{kg} kilograms";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for grams.");
            }
        }

        private void ConvertCmToMeters()
        {
            if (double.TryParse(inputTextBox.Text, out double cm))
            {
                double meters = cm / 100;
                resultLabel.Text = $"{meters} meters";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for centimeters.");
            }
        }

        private void ConvertMetersToCm()
        {
            if (double.TryParse(inputTextBox.Text, out double meters))
            {
                double cm = meters * 100;
                resultLabel.Text = $"{cm} centimeters";
            }
            else
            {
                MessageBox.Show("Please enter a valid number for meters.");
            }
        }
    }
}