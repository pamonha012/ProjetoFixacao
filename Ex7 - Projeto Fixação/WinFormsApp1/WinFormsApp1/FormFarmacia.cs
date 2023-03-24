using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp1
{
    public partial class FormFarmacia : Form
    {
        decimal valorUni, quantidade, subTotal, total;
        public FormFarmacia()
        {
            InitializeComponent();
            toolStripStatusLabelData.Text = DateTime.Now.ToLongDateString();

            comboBoxMarca.SelectedItem = "Selecionar marca";
            comboBoxMedicamento.SelectedItem = "Selecionar Medicamento";

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            textBoxValorUni.Enabled = false;
            textBoxSubTotal.Enabled = false;
            textBoxTotal.Enabled = false;
            buttonCalcular.Enabled = false;
            radioButtonCredito.Enabled = false;
            radioButtonDinheiro.Enabled = false;
        }
        public void limpar()
        {
            textBoxValorUni.Clear();
            textBoxQuantidade.Clear();
            textBoxSubTotal.Clear();
            radioButtonCredito.Checked = false;
            radioButtonDinheiro.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            buttonCalcular.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        public void addMarcas()
        {
            // vai adicionar items nos comboBox 
            comboBoxMarca.Items.Add("Selecionar marca");
            comboBoxMarca.Items.Add("Marca 1");
            comboBoxMarca.Items.Add("Marca 2");
            comboBoxMarca.Items.Add("Marca 3");
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMarca.Text == "Marca 1")
                {
                    textBoxValorUni.Clear();
                    comboBoxMedicamento.Items.Clear();
                    comboBoxMedicamento.Items.Add("Medicamento 1");

                }
                if (comboBoxMarca.Text == "Marca 2")
                {
                    textBoxValorUni.Clear();
                    comboBoxMedicamento.Items.Clear();
                    comboBoxMedicamento.Items.Add("Medicamento 1");
                }
                if (comboBoxMarca.Text == "Marca 3")
                {
                    textBoxValorUni.Clear();
                    comboBoxMedicamento.Items.Clear();
                    comboBoxMedicamento.Items.Add("Medicamento 1");
                }
                limpar();
                textBoxTotal.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void radioButtonCredito_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                subTotal = quantidade * valorUni;
                textBoxTotal.Text = subTotal.ToString();

                if (subTotal <= 350)
                {
                    radioButton1.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 351 && subTotal <= 1500)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 1501 && subTotal <= 5000)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
                else if (subTotal >= 5001)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    buttonCalcular.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            
            comboBoxMarca.SelectedIndex = 0;
            comboBoxMedicamento.SelectedIndex = -1;
            buttonCalcular.Enabled = false;
        }

        private void toolStripStatusLabelHora_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void comboBoxMedicamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxMedicamento.Text)
                {
                    case "Medicamento 1":
                        valorUni = 12;
                        break;
                    case "Medicamento 2":
                        valorUni = 10;
                        break;
                    case "Medicamento 3":
                        valorUni = 100;
                        break;
                    default:
                        break;
                }
                textBoxValorUni.Text = valorUni.ToString();
            }
            catch (Exception)
            {
            }


        }
    }
    }
}
