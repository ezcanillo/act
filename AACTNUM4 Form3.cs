using System;
using System.Windows.Forms;

namespace AACTNUM4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Add event handler for the calculator menu item
            calculatorToolStripMenuItem.Click += CalculatorToolStripMenuItem_Click;
        }

        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a message to confirm the event is triggered
            MessageBox.Show("Opening the calculator form...");

            // Create an instance of Form4 (calculator)
            Form4 calculatorForm = new Form4();

            // Subscribe to Form4's FormClosed event to show Form3 again
            calculatorForm.FormClosed += (s, args) =>
            {
                // Show Form3 again when Form4 is closed
                this.Show();
            };

            // Hide Form3 and show Form4
            this.Hide();
            calculatorForm.ShowDialog(); // This blocks Form3 until Form4 is closed

            // After closing Form4, Form3 should reappear (via FormClosed handler)
        }

        // Optionally add this to ensure Form3 is correctly initialized
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            MessageBox.Show("Form3 is shown"); // Debugging confirmation
        }
    }
}
