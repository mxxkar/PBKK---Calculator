using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        private decimal valuefirst = 0.0m;
        private decimal valuesecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void butt0_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "0";
            }
            else
            {
                Textbox.Text += "0";
            }
        }

        private void Dotbutt_Click(object sender, EventArgs e)
        {
            if (!Textbox.Text.Contains("."))
            {
                Textbox.Text += ".";
            }
        }

        private void Equalbutt_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valuesecond = decimal.Parse(Textbox.Text);
                    Result = valuefirst - valuesecond;
                    Textbox.Text = Result.ToString();
                    break;
                case "+":
                    valuesecond = decimal.Parse(Textbox.Text);
                    Result = valuefirst + valuesecond;
                    Textbox.Text = Result.ToString();
                    break;
                case "*":
                    valuesecond = decimal.Parse(Textbox.Text);
                    Result = valuefirst * valuesecond;
                    Textbox.Text = Result.ToString();
                    break;
                case "/":
                    valuesecond = decimal.Parse(Textbox.Text);
                    Result = valuefirst / valuesecond;
                    Textbox.Text = Result.ToString();
                    break;
                case "%":
                    valuesecond = decimal.Parse(Textbox.Text);
                    Result = valuefirst % valuesecond;
                    Textbox.Text = Result.ToString();
                    break;
            }
        }

        private void butt1_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "1";
            }
            else
            {
                Textbox.Text += "1";
            }
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "2";
            }
            else
            {
                Textbox.Text += "2";
            }
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "3";
            }
            else
            {
                Textbox.Text += "3";
            }
        }

        private void butt4_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "4";
            }
            else
            {
                Textbox.Text += "4";
            }
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "5";
            }
            else
            {
                Textbox.Text += "5";
            }
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "6";
            }
            else
            {
                Textbox.Text += "6";
            }
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "7";
            }
            else
            {
                Textbox.Text += "7";
            }
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "8";
            }
            else
            {
                Textbox.Text += "8";
            }
        }

        private void butt9_Click(object sender, EventArgs e)
        {
            if (Textbox.Text == "0")
            {
                Textbox.Text = "9";
            }
            else
            {
                Textbox.Text += "9";
            }
        }

        private void Minplusbutt_Click(object sender, EventArgs e)
        {
            if (Textbox.Text.Contains("-"))
            {
                Textbox.Text = Textbox.Text.Trim('-');
            }
            else
            {
                Textbox.Text = "-" + Textbox.Text;
            }
        }

        private void Minbutt_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(Textbox.Text);
            Textbox.Clear();
            operators = "-";
        }

        private void Plusbutt_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(Textbox.Text);
            Textbox.Clear();
            operators = "+";
        }

        private void Devidebutt_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(Textbox.Text);
            Textbox.Clear();
            operators = "/";
        }

        private void Multiplebutt_Click(object sender, EventArgs e)
        {
            valuefirst = decimal.Parse(Textbox.Text);
            Textbox.Clear();
            operators = "*";
        }

        private void Clearbutt_Click(object sender, EventArgs e)
        {
            valuefirst = 0.0m;
            valuesecond = 0.0m;
            Textbox.Text = "0";
        }
    }
}
