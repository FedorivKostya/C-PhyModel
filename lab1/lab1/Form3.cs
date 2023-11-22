using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            double omega = 0;
            if (this.DialogResult == DialogResult.OK)
            {
                try
                {

                    omega = Convert.ToDouble(maskedTextBox1.Text.Substring(0));
                }
                catch (FormatException)
                {
                    e.Cancel = true;
                }
                if (omega > 2)
                {
                    MessageBox.Show("Введите значение меньше 2 рад/с");
                    e.Cancel = true;
                }
                Form1.omega = omega;
            }
        }

        private void Form3_FormClosing(object sender, FormClosedEventArgs e)
        {

        }
    }
}
