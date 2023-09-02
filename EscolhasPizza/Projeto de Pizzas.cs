namespace EscolhasPizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chk4Queijos.Checked = false;
            chkBacon.Checked = false;
            chkCafé.Checked = false;
            chkCalabresa.Checked = false;
            chkPortuguesa.Checked = false;
            chkRefrigerante.Checked = false;
            chkSuco.Checked = false;
            chkAgua.Checked = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPagamento.Text = cmbFormaPagamento.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCalabresa.Checked)
            {
                lbPizza.Text += "Calabresa ";
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lbAdicional.Text = cmbAdicional.SelectedItem.ToString();
        }

        private void chk4Queijos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4Queijos.Checked)
            {
                lbPizza.Text += "4 Queijos ";
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
        }

        private void chkPortuguesa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPortuguesa.Checked)
            {
                lbPizza.Text += "Portuguesa ";
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
            }
        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBacon.Checked)
            {
                lbPizza.Text += "Bacon ";
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void chkRefrigerante_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRefrigerante.Checked)
            {
                lbBebida.Text += "Refrigerante ";
                chkSuco.Checked = false;
                chkAgua.Checked = false;
                chkCafé.Checked = false;

            }
        }

        private void chkCafé_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCafé.Checked)
            {
                lbBebida.Text += "Café ";
                chkRefrigerante.Checked = false;
                chkSuco.Checked = false;

                chkAgua.Checked = false;

            }
        }

        private void chkAgua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAgua.Checked)
            {
                lbBebida.Text += "Agua ";
                chkCafé.Checked = false;
                chkSuco.Checked = false;
                chkRefrigerante.Checked = false;

            }
        }

        private void chkSuco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSuco.Checked)
            {
                lbBebida.Text += "Suco ";
            }
        }

        private void cmbAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdicional.Text = cmbAdicional.SelectedIndex.ToString();
        }

        private void chkLimparBebida_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLimparBebida.Checked)
            {
                lbBebida.Text = "";
                chkSuco.Checked = false;
                chkAgua.Checked = false;
                chkRefrigerante.Checked = false;
                chkCafé.Checked = false;

            }
        }

        private void chkLimparPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLimparPizza.Checked)
            {
                lbPizza.Text = "";
                chk4Queijos.Checked = false;
                chkBacon.Checked = false;
                chkCalabresa.Checked = false;
                chkPortuguesa.Checked = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}