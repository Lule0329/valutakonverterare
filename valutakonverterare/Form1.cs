using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace valutakonverterare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox1.Text) >= 0) // Konverterar från SEK
            {
                textBox2.Text = Math.Round(double.Parse(textBox1.Text) / 11.6, 1, 0).ToString();
                textBox3.Text = Math.Round(double.Parse(textBox1.Text) / 10.8, 1, 0).ToString();
                textBox4.Text = Math.Round(double.Parse(textBox1.Text) / 13.5, 1, 0).ToString();
            }
            else if (double.Parse(textBox2.Text) >= 0) // Konverterar från Euro
            {
                textBox1.Text = Math.Round(double.Parse(textBox2.Text) * 11.6, 1, 0).ToString();
                textBox3.Text = Math.Round(double.Parse(textBox2.Text) * 1.07, 1, 0).ToString();
                textBox4.Text = Math.Round(double.Parse(textBox2.Text) * 0.86, 1, 0).ToString();
            }
            else if (double.Parse(textBox3.Text) >= 0) // Konverterar från USD
            {
                textBox1.Text = Math.Round(double.Parse(textBox3.Text) * 10.8, 1, 0).ToString();
                textBox2.Text = Math.Round(double.Parse(textBox3.Text) / 1.07, 1, 0).ToString();
                textBox4.Text = Math.Round(double.Parse(textBox3.Text) * 0.8, 1, 0).ToString();
            }
            else if (double.Parse(textBox4.Text) >= 0) // Konverterar från Pund
            {
                textBox1.Text = Math.Round(double.Parse(textBox4.Text) * 13.5, 1, 0).ToString();
                textBox2.Text = Math.Round(double.Parse(textBox4.Text) / 0.86, 1, 0).ToString();
                textBox3.Text = Math.Round(double.Parse(textBox4.Text) / 0.8, 1, 0).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
