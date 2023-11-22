using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                Form1.R = Convert.ToInt32(numericUpDown1.Value);
                Form1.r = Convert.ToInt32(numericUpDown2.Value);
            }
            else
            {
                numericUpDown1.Value = Form1.R;
                numericUpDown2.Value = Form1.r;
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            numericUpDown1.Value = Form1.R;
            numericUpDown2.Value = Form1.r;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
