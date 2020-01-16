using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFormCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            //int operand1 = Convert.ToInt32(numOperand1.Value);
            //int operand2 = Convert.ToInt32(numOperand2.Value);
            //int result = operand1 + operand2;
            //boxResult.Text = Convert.ToString(result);
            double operand1 = Convert.ToDouble(numOperand1.Value);
            double operand2 = Convert.ToDouble(numOperand2.Value);
            double result = operand1 + operand2;
            boxResult.Text = Convert.ToString(result);
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(numOperand1.Value);
            double operand2 = Convert.ToDouble(numOperand2.Value);
            double result = operand1 - operand2;
            boxResult.Text = Convert.ToString(result);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            double operand1 = Convert.ToDouble(numOperand1.Value);
            double operand2 = Convert.ToDouble(numOperand2.Value);
            double result = operand1 * operand2;
            boxResult.Text = Convert.ToString(result);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if(numOperand2.Value == 0)
            {
                MessageBox.Show("Dividing by zero is not reccommended.");
                numOperand2.Value = 1;
            }
            else
            {
                double operand1 = Convert.ToDouble(numOperand1.Value);
                double operand2 = Convert.ToDouble(numOperand2.Value);
                double result = operand1 / operand2;
                boxResult.Text = Convert.ToString(result);
            }
            
        }

        private void ClearBox_Click(object sender, EventArgs e)
        {
            numOperand2.Value = 0;
            numOperand1.Value = 0;
            boxResult.Text = "0";
        }
    }
}
