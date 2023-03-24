using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormParImpar : Form
    {
        public FormParImpar()
        {
            InitializeComponent();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            bool letra = int.TryParse(textBoxImparPar.Text, out numero);


            try
            {
                if (textBoxImparPar.Text == string.Empty )
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "ATENÇÃO\n", MessageBoxButtons.OK);
                }
                else if (letra == false)
                {
                    MessageBox.Show("Insira apenas números inteiros", "ATENÇÃO\n", MessageBoxButtons.OK);
                }
                else
                {
                    numero = Convert.ToInt32(textBoxImparPar.Text);
                    if (numero % 2 == 0)
                    {
                        MessageBox.Show("O número " + numero + " é par", "NÚMERO PAR\n", MessageBoxButtons.OK);
                        textBoxImparPar.Clear();
                    }
                    else
                    {
                        MessageBox.Show("O número " + numero + " é ímpar", "NÚMERO ÍMPAR\n", MessageBoxButtons.OK);
                        textBoxImparPar.Clear();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxImparPar.Clear();
        }
    }
}
