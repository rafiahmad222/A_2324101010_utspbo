using System.Security.Cryptography;

namespace A_232410101007_utspbo
{
    partial class Welcome
    {
        private System.ComponentModel.IContainer components = null;
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(66, 241);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Kontak";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(256, 241);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(442, 241);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
        }
        public Button button1;
        public Button button2;
        public Button button3;
    }
}