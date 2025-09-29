namespace For_practice_purpose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("India");
            listBox2.Items.Add("New zealand");
            listBox2.Items.Add("Nepal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
        }
    }
}
