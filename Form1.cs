namespace Project_GUICurrencyConverter
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {

        }

        private void ConvertCurrency(object sender, EventArgs e)
        {
            const decimal ConversionCoefficeient = 1.95583m;
            decimal amountBGN = this.numericUpDownAmount.Value;
            decimal amountEUR = amountBGN / ConversionCoefficeient;
            this.resultLable.Text = $"{amountBGN} BGN = {amountEUR:F2} EUR";
        }
    }
}