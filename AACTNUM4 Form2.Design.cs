using System.Drawing;
using System.Windows.Forms;

namespace AACTNUM4
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(50, 100);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 30);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(50, 150);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 1;
            button1.Text = "Start Progress";
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button3
            // 
            button3.Location = new Point(300, 150);
            button3.Name = "button3";
            button3.Size = new Size(150, 30);
            button3.TabIndex = 2;
            button3.Text = "Next Form3";
            // 
            // Form2
            // 
            ClientSize = new Size(482, 253);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Progress Bar Demo";
            ResumeLayout(false);
        }
        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}
