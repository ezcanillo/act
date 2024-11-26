using System;
using System.Windows.Forms;

namespace actnum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click; // Attach event handler
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Check for empty text boxes
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill up the NAME field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill up the AGE field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill up the CONTACT NO field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill up the ADDRESS field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill up the FATHER'S NAME field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill up the MOTHER'S NAME field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Display the input values
            string output = $"Name: {textBox1.Text}\n" +
                            $"Age: {textBox2.Text}\n" +
                            $"Contact No: {textBox3.Text}\n" +
                            $"Address: {textBox4.Text}\n" +
                            $"Father's Name: {textBox5.Text}\n" +
                            $"Mother's Name: {textBox6.Text}";
            MessageBox.Show(output, "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
