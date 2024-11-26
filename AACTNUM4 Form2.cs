using System;
using System.Windows.Forms;

namespace AACTNUM4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Add the click event for button3
            button3.Click += button3_Click;
        }

        // Existing button1 and timer1 methods...
        private void button1_Click(object sender, EventArgs e)
        {
            // Your existing progress bar start logic
            timer1.Interval = 50;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Your existing progress bar increment logic
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Stop();
            }
        }

        // New method to open Form3
        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form3
            Form3 form3 = new Form3();

            // Optional: Hide the current form
            this.Hide();

            // Show Form3
            form3.ShowDialog();

            // Optional: Close the current form after Form3 is closed
            // Uncomment the next line if you want to close Form2 completely
            // this.Close();
        }
    }
}
