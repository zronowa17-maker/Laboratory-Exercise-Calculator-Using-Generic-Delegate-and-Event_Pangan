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


                string selectedOperator = cbOperator.SelectedItem.ToString();
                double result;

                switch (selectedOperator)
                {
                    case "+":
                        result = cal.GetSum(num1, num2);
                        break;
                    case "-":
                        result = cal.GetDifference(num1, num2);
                        break;
                    case "*":
                        result = cal.GetProduct(num1, num2);
                        break;
                    case "/":
                        result = cal.GetQuotient(num1, num2);
                        break;
                    default:
                       
                        MessageBox.Show("Please select an operator.", "Invalid Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                lblDisplayTotal.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an operator.", "Missing Operator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
