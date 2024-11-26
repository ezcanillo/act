namespace AACTNUM4
{
    public partial class Form1 : Form
    {
        // The correct username and password
        private const string correctUsername = "earl";
        private const string correctPassword = "earl01";

        public Form1()
        {
            InitializeComponent();
        }

        // Handle the "OK" button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate username and password
            if (textBox1.Text == correctUsername && textBox2.Text == correctPassword)
            {
                // Hide the current form and open Form2 on successful login
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();  // Optionally hide the login form
            }
            else
            {
                // Display a warning if credentials are incorrect
                MessageBox.Show("Invalid username or password. Try again.");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        // Handle the "CLOSE" button click to close the application
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Set the password masking on load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Mask the password field with asterisks (*) when the user types
            textBox2.PasswordChar = '*';
        }
    }
}
