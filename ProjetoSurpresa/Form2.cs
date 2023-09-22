using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSurpresa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcularMarte_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPesoTerra.Text, out double pesoTerra))
            {

                lblResultado.Text = "";

                double gravidadeTerra = 9.81;
                double gravidadeMarte = 3.72076;
                double pesoMarte = (pesoTerra * gravidadeMarte) / gravidadeTerra;

                lblResultado.Text = $"Peso em Marte: {pesoMarte:N2} N\n";

            }
            else
            {
                MessageBox.Show("Insira um valor valido para o peso na Terra");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtPesoTerra.Text, out double pesoTerra))
            {

                lblResultado.Text = "";

                double gravidadeTerra = 9.81;
                double gravidadeVenus = 8.87;

                double pesoVenus = (pesoTerra * gravidadeVenus) / gravidadeTerra;

                lblResultado.Text += $"Peso em Vênus: {pesoVenus:N2} N";
            }
        }

        private void btnCalcularJupiter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPesoTerra.Text, out double pesoTerra))
            {

                lblResultado.Text = "";

                double gravidadeTerra = 9.81;
                double gravidadeJupiter = 24.79;

                double pesoJupiter = (pesoTerra * gravidadeJupiter) / gravidadeTerra;

                lblResultado.Text += $"Peso em Júpiter: {pesoJupiter:N2} N\n";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtPesoTerra.Text = "";
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.Show();
            this.Hide();
        }
    }
}
