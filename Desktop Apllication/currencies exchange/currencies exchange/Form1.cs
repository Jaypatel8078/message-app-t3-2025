namespace currencies_exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amountNz = decimal.Parse(textBox1.Text);
            decimal exchangerateNztoUSD = 0.61m;
            decimal exchangerateNztoINR = 50.90m;
            decimal amountUSD = amountNz * exchangerateNztoUSD;
            decimal amountINR = amountNz * exchangerateNztoINR;
            label4.Text = amountUSD.ToString();
            label5.Text = amountINR.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = string.Empty;
            label5.Text = string.Empty;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}

