namespace NumerosImpares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ltbNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, i;
            num = Convert.ToInt32(txbVal.Text);
            
            for (i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    ltbNumeros.Items.Add(i.ToString());
                }

            }
        }

            private void button1_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnLimpar_Click(object sender, EventArgs e)
            {
                txbVal.Text = "";
                ltbNumeros.Items.Clear();
            }
        } 
}