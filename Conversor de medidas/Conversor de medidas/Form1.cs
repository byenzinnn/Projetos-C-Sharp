namespace Conversor_de_medidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMedidas_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show();
            this.Hide();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.Show();
            this.Hide();
        }
    }
}