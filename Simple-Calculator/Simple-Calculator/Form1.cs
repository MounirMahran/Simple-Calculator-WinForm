using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float Num1;
        float Num2;
        char Operation;
        bool OperationPressed = false;
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (OperationPressed) {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (OperationPressed)
            {
                textBox1.Text = "";
                OperationPressed = false;
            }
            textBox1.Text += "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
       {
            OperationPressed = true;
            Operation = '+';
            Num1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            OperationPressed = true;
            Operation = '-';
            Num1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "-";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {   
            OperationPressed = true;
            Operation = '*';
            Num1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            OperationPressed = true;
            Operation = '/';
            Num1 = Convert.ToSingle(textBox1.Text);
            textBox1.Text = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            OperationPressed = true;
            Num2 = Convert.ToSingle(textBox1.Text);
            switch(Operation)
            {
                case '+':
                    textBox1.Text = Convert.ToString(Num1 + Num2);
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(Num1 - Num2);
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(Num1 * Num2);
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(Num1 / Num2);
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
