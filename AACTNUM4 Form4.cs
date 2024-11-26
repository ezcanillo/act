using System;
using System.Windows.Forms;

namespace AACTNUM4
{
    public partial class Form4 : Form
    {
        private int sw = 0;
        private int holdnum = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtNum.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "0")
            {
                txtNum.Text += "1";
            }
            else
            {
                txtNum.Text = "1";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sw = 1;
            holdnum = int.Parse(txtNum.Text);
            txtNum.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (sw == 1)
            {
                txtNum.Text = (holdnum + int.Parse(txtNum.Text)).ToString();
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNum.Text != "0")
            {
                txtNum.Text += "0";
            }
        }
    }
}
