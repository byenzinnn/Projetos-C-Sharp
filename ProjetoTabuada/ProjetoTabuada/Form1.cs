namespace ProjetoTabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            int num, cont, tab;
            num = Convert.ToInt32(txbNum.Text);

            for (cont = 0; cont <= 10; cont++)
            {
                tab = num * cont;

                ltbTabuada.Items.Add(num.ToString()+ " * " + cont.ToString()+ " = "
                    + tab.ToString());
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNum.Text = "";
            ltbTabuada.Items.Clear();

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}