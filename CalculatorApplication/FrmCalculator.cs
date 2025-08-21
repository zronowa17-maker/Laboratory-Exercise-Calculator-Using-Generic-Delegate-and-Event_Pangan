namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }
    }
}
