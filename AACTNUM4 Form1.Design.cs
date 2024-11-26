namespace AACTNUM4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();

            // Form1
            this.ClientSize = new System.Drawing.Size(490, 194);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Form1";
            this.Text = "Login Form";

            // label1 (User Name)
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(33, 30);
            label1.Name = "label1";
            label1.Text = "User Name:";

            // label2 (Password)
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 100);
            label2.Name = "label2";
            label2.Text = "Password:";

            // textBox1 (Username Input)
            textBox1.Location = new System.Drawing.Point(136, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(270, 27);

            // textBox2 (Password Input)
            textBox2.Location = new System.Drawing.Point(136, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(270, 27);

            // button1 (OK Button)
            button1.Location = new System.Drawing.Point(136, 141);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.Text = "OK";
            button1.Click += new System.EventHandler(button1_Click); // Ensure this is hooked up

            // button2 (Close Button)
            button2.Location = new System.Drawing.Point(259, 141);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.Text = "CLOSE";
            button2.Click += new System.EventHandler(button2_Click); // Ensure this is hooked up

            // Form load to set password char for textbox2
            this.Load += new System.EventHandler(Form1_Load);
        }
    }
}
