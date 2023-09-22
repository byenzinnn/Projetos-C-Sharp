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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            float resultado;

            val1 = Convert.ToInt16(textVal1.Text);
            val2 = Convert.ToInt16(textVal2.Text);
            resultado = val1 + val2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            float resultado;

            val1 = Convert.ToInt16(textVal1.Text);
            val2 = Convert.ToInt16(textVal2.Text);
            resultado = val1 - val2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            float resultado;

            val1 = Convert.ToInt16(textVal1.Text);
            val2 = Convert.ToInt16(textVal2.Text);
            resultado = val1 * val2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int val1;
            int val2;
            float resultado;

            val1 = Convert.ToInt16(textVal1.Text);
            val2 = Convert.ToInt16(textVal2.Text);
            resultado = val1 / val2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textVal1.Text = "";
            textVal2.Text = "";
            txtResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            this.Hide();
            um.Show();
        }
    }
}
