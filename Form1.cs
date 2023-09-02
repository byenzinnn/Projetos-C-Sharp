namespace Conversor_de_medidas_e_velocidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void icon1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnQuilometros_Click(object sender, EventArgs e)
        {
            try
            {
                string textoDaTextBox = txtVal1.Text;
                double valorDouble = Double.Parse(textoDaTextBox);

                if (valorDouble > 0)
                {
                    lbResultado.Text = valorDouble.ToString();
                    
                    

                }


            }
            catch (FormatException)
            {

            }
        }
    }
}