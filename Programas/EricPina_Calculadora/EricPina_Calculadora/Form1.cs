using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EricPina_Calculadora
{
    public partial class Form1 : Form
    {
        double Num1 = 0;
        double Num2 = 0;
        char Op;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Num1 = 0;
            Num2 = 0;
            ResultBox.Text = "\0";
            ResultBox.Text = "0";
        }

        private void addNum(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            if (ResultBox.Text=="0")
            {
                ResultBox.Text = "";
            }
            ResultBox.Text += btn.Text;
        }
        private void OpEvent(object sender, EventArgs e)
        {
            var btn = ((Button)sender);

            Num1 = Convert.ToDouble(ResultBox.Text);

            Op = Convert.ToChar(btn.Tag);

            if (Op == '√')
            {
                Num1 = Math.Sqrt(Num1);
                ResultBox.Text = Num1.ToString();
            }
            else if (Op == '²')
            {
                Num1 = Math.Pow(Num1, 2);
                ResultBox.Text = Num1.ToString();
            }
            else 
            {
                ResultBox.Text = "0";
            }
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Num2 = Convert.ToDouble(ResultBox.Text); //problemita
            

            if (Op=='+')
            {
                ResultBox.Text = (Num1 + Num2).ToString();
                Num1 = Convert.ToDouble(ResultBox.Text);
            }
            else if (Op=='-')
            {
                ResultBox.Text = (Num1 - Num2).ToString();
                Num1 = Convert.ToDouble(ResultBox.Text);
            }
            else if (Op == '×')
            {
                ResultBox.Text = (Num1 * Num2).ToString();
                Num1 = Convert.ToDouble(ResultBox.Text);
            }
            else if (Op == '÷')
            {
                if (ResultBox.Text != "0")
                {
                    ResultBox.Text = (Num1 / Num2).ToString();
                    Num1 = Convert.ToDouble(ResultBox.Text);
                }
                else
                {
                    MessageBox.Show("Argumento Invalido. No se puede dividir entre 0.");
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (ResultBox.Text.Length > 1)
            {
                ResultBox.Text = ResultBox.Text.Substring(0,ResultBox.Text.Length - 1);
            }
            else
            {
                ResultBox.Text = "0";
            }
        }

        private void clearEBtn_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            if (!ResultBox.Text.Contains("."))
            {
                ResultBox.Text += ".";
            }
        }

        private void signBtn_Click(object sender, EventArgs e)
        {
            /*
            Num1 = Convert.ToDouble(ResultBox.Text);
            Num1 *= -1;
            ResultBox.Text = Num1.ToString();
            */
            double actNum = Convert.ToDouble(ResultBox.Text);
            actNum *= -1;
            ResultBox.Text = actNum.ToString();

        }
    }
}
