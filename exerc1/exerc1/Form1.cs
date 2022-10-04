namespace exerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datePicker = dateTimePicker1.Text.Split('/');
            var day = DateTime.Now.Day;
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month;

            Idade calcIdade = new Idade();

            double idadeAno = calcIdade.calcIdadeAnos(Double.Parse(datePicker[2]), Double.Parse(year.ToString()));
            double idadeMes = calcIdade.calcIdadeMes(Double.Parse(datePicker[1]), month, idadeAno);

            double idadeSemana = calcIdade.calcIdadeSemana(idadeMes, idadeAno);

            listBox1.Items.Add(idadeAno);
            listBox1.Items.Add(idadeMes);
            listBox1.Items.Add(idadeSemana);
        }

    }
}