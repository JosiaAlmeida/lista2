namespace exerc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataDifference diferencaData = new DataDifference(dateTimePicker1.Value, dateTimePicker2.Value);

            result.Text = "Diferen�a entre" + "\n"+ dateTimePicker1.Value + " e \n"+ dateTimePicker2.Value+"\n �: \n"+ diferencaData.ToString();

        }
    }
}