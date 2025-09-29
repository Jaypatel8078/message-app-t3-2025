namespace loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "password";
            string enteredusername = textBox1.Text;
            string enteredpassword = textBox2.Text; 
            
            if (enteredusername == "admin" && enteredpassword == "password")
            {
                MessageBox.Show("login successful!");
            }
            else
            {
                MessageBox.Show("invalid username and password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
