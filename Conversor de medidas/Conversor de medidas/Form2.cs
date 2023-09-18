using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_medidas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbmMed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMed.Text, out double valor))
            {
                if (cmbMed1.SelectedIndex == 0 && cmbMed2.SelectedIndex == 0)
                {
                    lbResultado.Text = valor.ToString();
                }
                else if (cmbMed1.SelectedIndex == 0 && cmbMed2.SelectedIndex == 1)
                {
                    double resultado = valor / 100;
                    lbResultado.Text = resultado.ToString();

                }
                else if (cmbMed1.SelectedIndex == 0 && cmbMed2.SelectedIndex == 2)
                {
                    double resultado = valor / 1000;
                    lbResultado.Text = resultado.ToString();
                }
                else if (cmbMed1.SelectedIndex == 1 && cmbMed2.SelectedIndex == 0)
                {
                    double resultado = valor / 100;
                    lbResultado.Text = resultado.ToString();
                }
                else if (cmbMed1.SelectedIndex == 1 && cmbMed2.SelectedIndex == 1)
                {
                    lbResultado.Text = valor.ToString();
                }
                else if (cmbMed1.SelectedIndex == 1 && cmbMed2.SelectedIndex == 2)
                {
                    double resultado = valor / 100000;
                    lbResultado.Text = resultado.ToString();
                }
                else if (cmbMed1.SelectedIndex == 2 && cmbMed2.SelectedIndex == 0)
                {
                    double resultado = valor * 1000;
                    lbResultado.Text = resultado.ToString();
                }
                else if (cmbMed1.SelectedIndex == 2 && cmbMed2.SelectedIndex == 1)
                {
                    double resultado = valor * 100000;
                    lbResultado.Text = resultado.ToString();
                }
                else
                {
                    lbResultado.Text = valor.ToString();
                }

            }
            else
            {
                MessageBox.Show("Insira um valor valido!");
            }
        }

        private void cmbMed2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
