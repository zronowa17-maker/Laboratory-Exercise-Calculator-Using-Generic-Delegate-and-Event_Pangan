using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {

        private CalculatorClass cal;
        private double num1;
        private double num2;


        public FrmCalculator()
        {

            InitializeComponent();

            cal = new CalculatorClass();
        }


        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                double input1 = Convert.ToDouble(txtBoxInput1.Text);
                double input2 = Convert.ToDouble(txtBoxInput2.Text);

                num1 = input1;
                num2 = input2;

              
                double result = cal.GetSum(num1, num2);

                MessageBox.Show($"The result is: {result}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }
}
