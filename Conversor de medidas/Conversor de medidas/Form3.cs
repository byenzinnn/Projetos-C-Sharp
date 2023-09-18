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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

                if (double.TryParse(txtTemp.Text, out double valor))
                {
                    if (cmbTemp1.SelectedIndex == 0 && cmbTemp2.SelectedIndex == 0)
                    {
                        lbResultado2.Text = valor.ToString();

                    }
                    else if (cmbTemp1.SelectedIndex == 0 && cmbTemp2.SelectedIndex == 1)
                    {
                        double resultado = (valor * 9 / 5) + 32;
                        lbResultado2.Text = resultado.ToString() + "°F";
                    }
                    else if (cmbTemp1.SelectedIndex == 0 && cmbTemp2.SelectedIndex == 2)
                    {
                        double resultado = valor + 273.15;
                        lbResultado2.Text = resultado.ToString() + " K";
                    }
                    else if (cmbTemp1.SelectedIndex == 1 && cmbTemp2.SelectedIndex == 0)
                    {
                        double resultado = (valor - 32) * 5 / 9;
                        lbResultado2.Text = resultado.ToString() + " °C";
                    }
                    else if (cmbTemp1.SelectedIndex == 1 && cmbTemp2.SelectedIndex == 1)
                    {
                        lbResultado2.Text = valor.ToString();
                    }
                    else if (cmbTemp1.SelectedIndex == 1 && cmbTemp2.SelectedIndex == 2)
                    {
                        double resultado = (valor - 32) * 5 / 9 + 273.15;
                        lbResultado2.Text = resultado.ToString() + " K";

                    }
                    else if (cmbTemp1.SelectedIndex == 2 && cmbTemp2.SelectedIndex == 0)
                    {
                        double resultado = valor - 273.15;
                        lbResultado2.Text = resultado.ToString() + " °C";
                    }
                    else if (cmbTemp1.SelectedIndex == 2 && cmbTemp2.SelectedIndex == 1)
                    {
                        double resultado = (valor - 273.15) * 9 / 5 + 32;
                        lbResultado2.Text = resultado.ToString();
                    }
                    else
                    {
                        lbResultado2.Text = valor.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Insira um valor válido!");
                }
        }
    }
}
