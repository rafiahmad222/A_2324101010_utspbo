namespace A_232410101007_utspbo
{
    public partial class Welcome : Form
    {
        public Button button1;
        public Button button2;
        public Button button3
        public Welcome()
        {
            InitializeComponent();
        }
        
        public class WelcomeEventArgs : EventArgs {
            public string Message { get; set; }
        }

        public class Kontak : Form
        {
            public Kontak()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // Kontak
                // 
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Name = "Kontak";
                this.ResumeLayout(false);
            }
        }
        public class Register : Form
        {
            public Register()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // Register
                // 
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Name = "Register";
                this.ResumeLayout(false);
            }
        }
        public class Login : Form
        {
            public Login()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // Login
                // 
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Name = "Login";
                this.ResumeLayout(false);
            }
        }
        private void Welcome_Load(object sender, EventArgs e)
        {
            async void button1_Click(object sender, EventArgs e)
            {
                Kontak kontak = new Kontak();
                kontak.Show();
                this.Hide();
            }

            async void button2_Click(object sender, EventArgs e)
            {
                Register register = new Register();
                register.Show();
                this.Hide();
            }

            async void button3_Click(object sender, EventArgs e)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
    }
}   
