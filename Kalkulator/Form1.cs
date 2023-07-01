using System.Globalization;
namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double pierwsza = 0;
        string dzialanie = "";
        bool czyDzial = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "ERR")
                textBox1.Text = "0";
            if (button.Text == ",")
            {
                if (!(textBox1.Text.Contains(",") || textBox1.Text.Contains("E")))
                {
                    NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
                    String decimalSeparator = nfi.NumberDecimalSeparator;
                    textBox1.Text += decimalSeparator;
                }
            }
            else
                if (textBox1.Text == "0")
                {
                    textBox1.Text = button.Text;
                }
                else textBox1.Text += button.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "ERR")
            {
                Button buttonOpe = (Button)sender;
                pierwsza = Double.Parse(textBox1.Text);
                dzialanie = buttonOpe.Text;
                textBox1.Text = "0";
            }
        }

        private void buttonZnak_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "ERR")
            {
            double pomoc = Double.Parse(textBox1.Text);
                if (pomoc != 0)
                {
                    pomoc *= (-1);
                    textBox1.Text = pomoc.ToString();
                }
            }
        }

        private void buttonRow_Click(object sender, EventArgs e)
        {
            double pomoc = Double.Parse(textBox1.Text);
            switch (dzialanie)
            {
                case "+":
                    textBox1.Text = (pierwsza + pomoc).ToString();
                    break;
                case "-":
                    textBox1.Text = (pierwsza - pomoc).ToString();
                    break;
                case "x":
                    textBox1.Text = (pierwsza * pomoc).ToString();
                    break;
                case ":":
                    if (pierwsza == 0 || pomoc == 0)
                    {
                        textBox1.Text = "ERR";
                        break;
                    }
                    textBox1.Text = (pierwsza / pomoc).ToString();
                    break;
                default: break;
            }
        }
    }
}