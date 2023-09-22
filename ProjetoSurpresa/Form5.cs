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
    public partial class Form5 : Form
    {
        private int numeroAleatorio;
        private int tentativas = 0;
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1, 101); // Gera um número entre 1 e 100
            tentativas = 0;
            lblResultado.Text = "";
            lblTentativas.Text = "Tentativas: 0";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSuposicao.Text, out int suposicao))
            {
                tentativas++;

                if (suposicao < numeroAleatorio)
                {
                    lblResultado.Text = "Muito baixo!";
                }
                else if (suposicao > numeroAleatorio)
                {
                    lblResultado.Text = "Muito alto!";
                }
                else
                {
                    lblResultado.Text = $"Correto! O número era {numeroAleatorio}.";
                    MessageBox.Show($"Você acertou em {tentativas} tentativas!", "Parabéns!");
                    tentativas = 0;
                }

                lblTentativas.Text = $"Tentativas: {tentativas}";
            }
            else
            {
                MessageBox.Show("Insira um número válido.");
            }

            txtSuposicao.Clear();
            txtSuposicao.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 um = new Form1();
            um.Show();
            this.Close();
        }
    }
}
