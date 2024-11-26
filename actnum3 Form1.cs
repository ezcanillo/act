using System;
using System.Windows.Forms;

namespace actnum3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click; // Add event handler for Add Record button
            button2.Click += Button2_Click; // Add event handler for Delete Record button

            // Add header row on form load
            listBox1.Items.Add("Name".PadRight(30) + "Date");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string birthDate = dateTimePicker1.Value.ToString("dddd, MMMM dd, yyyy"); // Format the date

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add the record to the ListBox in aligned format
            string record = name.PadRight(30) + birthDate;
            listBox1.Items.Add(record);

            // Clear the input fields
            textBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0) // Prevent deleting the header row
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a valid record to delete.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
