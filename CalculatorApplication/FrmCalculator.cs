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
    }
}
