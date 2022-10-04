namespace exerc7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Primo primo = new Primo();
            foreach (var item in primo.Primos(double.Parse(textBox1.Text)))
            {
                listBox1.Items.Add(item);
            }
        }
    }
}