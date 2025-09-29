namespace practicemarking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1 = new ListView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            listView1 = new list((textBox1.Name), (textBox2.Text, dateTimePicker1);




        }
    }

    internal record struct list(string Item1, (string Text, DateTimePicker dateTimePicker1) Item2)
    {
        public static implicit operator (string, (string Text, DateTimePicker dateTimePicker1))(list value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator list((string, (string Text, DateTimePicker dateTimePicker1)) value)
        {
            return new list(value.Item1, value.Item2);
        }
    }
}
