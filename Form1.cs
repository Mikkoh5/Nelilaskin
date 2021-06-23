using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelilaskin
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        private int luku1;
        private int luku2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((textBoxTulos.Text == "0") || (isOperationPerformed))
                textBoxTulos.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textBoxTulos.Text.Contains(","))
                    textBoxTulos.Text = textBoxTulos.Text + button.Text;
                
            }
            else
            {
                textBoxTulos.Text = textBoxTulos.Text + button.Text;
            }
            textBoxLuku1.Text = button.Text;
            //textBoxLuku1.Text = "0";
        }

        private void Add()
        {
            luku1 = int.Parse(textBoxLuku1.ToString());
            luku2 = int.Parse(textBoxLuku2.ToString());

            textBoxTulos.Text = (luku1 + luku2).ToString();
        }

        private void Subtract()
        {
            luku1 = int.Parse(textBoxLuku1.ToString());
            luku2 = int.Parse(textBoxLuku2.ToString());

            textBoxTulos.Text = (luku1 - luku2).ToString();
        }

        private void Multiply()
        {
            luku1 = int.Parse(textBoxLuku1.ToString());
            luku2 = int.Parse(textBoxLuku2.ToString());

            textBoxTulos.Text = (luku1 * luku2).ToString();
        }

        private void Divide()
        {
            luku1 = int.Parse(textBoxLuku1.ToString());
            luku2 = int.Parse(textBoxLuku2.ToString());

            textBoxTulos.Text = (luku1 / luku2).ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void button0_click(object sender, EventArgs e)
        {

        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button1.PerformClick();
                operationPerformed = button.Text;
                labelTulos.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBoxTulos.Text);
                labelTulos.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxTulos.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxTulos.Text = "0";
            resultValue = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxTulos.Text = (resultValue + double.Parse(textBoxTulos.Text)).ToString();
                    break;
                case "-":
                    textBoxTulos.Text = (resultValue - double.Parse(textBoxTulos.Text)).ToString();
                    break;
                case "*":
                    textBoxTulos.Text = (resultValue * double.Parse(textBoxTulos.Text)).ToString();
                    break;
                case "/":
                    textBoxTulos.Text = (resultValue / double.Parse(textBoxTulos.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBoxTulos.Text);
            labelTulos.Text = "";
        }
    }
}
