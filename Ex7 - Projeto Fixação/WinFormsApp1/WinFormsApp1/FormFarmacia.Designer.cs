namespace WinFormsApp1
{
    partial class FormFarmacia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMedicamento = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxValorUni = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.groupBoxPagamento = new System.Windows.Forms.GroupBox();
            this.radioButtonPopular = new System.Windows.Forms.RadioButton();
            this.radioButtonCredito = new System.Windows.Forms.RadioButton();
            this.radioButtonDinheiro = new System.Windows.Forms.RadioButton();
            this.groupBoxParcelas = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Voltar = new System.Windows.Forms.Button();
            this.groupBoxPagamento.SuspendLayout();
            this.groupBoxParcelas.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do medicamento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Unitário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sub-Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(58, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(391, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Farmácia saúde em capsula";
            // 
            // comboBoxMedicamento
            // 
            this.comboBoxMedicamento.FormattingEnabled = true;
            this.comboBoxMedicamento.Location = new System.Drawing.Point(228, 83);
            this.comboBoxMedicamento.Name = "comboBoxMedicamento";
            this.comboBoxMedicamento.Size = new System.Drawing.Size(262, 33);
            this.comboBoxMedicamento.TabIndex = 6;
            this.comboBoxMedicamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedicamento_SelectedIndexChanged);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(82, 129);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(175, 33);
            this.comboBoxMarca.TabIndex = 7;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(376, 130);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(114, 33);
            this.textBoxQuantidade.TabIndex = 8;
            // 
            // textBoxValorUni
            // 
            this.textBoxValorUni.Location = new System.Drawing.Point(151, 176);
            this.textBoxValorUni.Name = "textBoxValorUni";
            this.textBoxValorUni.Size = new System.Drawing.Size(106, 33);
            this.textBoxValorUni.TabIndex = 9;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(360, 176);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(130, 33);
            this.textBoxSubTotal.TabIndex = 10;
            // 
            // groupBoxPagamento
            // 
            this.groupBoxPagamento.Controls.Add(this.radioButtonPopular);
            this.groupBoxPagamento.Controls.Add(this.radioButtonCredito);
            this.groupBoxPagamento.Controls.Add(this.radioButtonDinheiro);
            this.groupBoxPagamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPagamento.Location = new System.Drawing.Point(14, 220);
            this.groupBoxPagamento.Name = "groupBoxPagamento";
            this.groupBoxPagamento.Size = new System.Drawing.Size(243, 150);
            this.groupBoxPagamento.TabIndex = 14;
            this.groupBoxPagamento.TabStop = false;
            this.groupBoxPagamento.Text = "PAGAMENTO";
            // 
            // radioButtonPopular
            // 
            this.radioButtonPopular.AutoSize = true;
            this.radioButtonPopular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPopular.Location = new System.Drawing.Point(11, 102);
            this.radioButtonPopular.Name = "radioButtonPopular";
            this.radioButtonPopular.Size = new System.Drawing.Size(224, 29);
            this.radioButtonPopular.TabIndex = 2;
            this.radioButtonPopular.TabStop = true;
            this.radioButtonPopular.Text = "Farmácia Popular -15%";
            this.radioButtonPopular.UseVisualStyleBackColor = true;
            // 
            // radioButtonCredito
            // 
            this.radioButtonCredito.AutoSize = true;
            this.radioButtonCredito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCredito.Location = new System.Drawing.Point(11, 67);
            this.radioButtonCredito.Name = "radioButtonCredito";
            this.radioButtonCredito.Size = new System.Drawing.Size(92, 29);
            this.radioButtonCredito.TabIndex = 1;
            this.radioButtonCredito.TabStop = true;
            this.radioButtonCredito.Text = "Crédito";
            this.radioButtonCredito.UseVisualStyleBackColor = true;
            this.radioButtonCredito.CheckedChanged += new System.EventHandler(this.radioButtonCredito_CheckedChanged);
            // 
            // radioButtonDinheiro
            // 
            this.radioButtonDinheiro.AutoSize = true;
            this.radioButtonDinheiro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonDinheiro.Location = new System.Drawing.Point(11, 36);
            this.radioButtonDinheiro.Name = "radioButtonDinheiro";
            this.radioButtonDinheiro.Size = new System.Drawing.Size(103, 29);
            this.radioButtonDinheiro.TabIndex = 0;
            this.radioButtonDinheiro.TabStop = true;
            this.radioButtonDinheiro.Text = "Dinheiro";
            this.radioButtonDinheiro.UseVisualStyleBackColor = true;
            // 
            // groupBoxParcelas
            // 
            this.groupBoxParcelas.Controls.Add(this.textBox4);
            this.groupBoxParcelas.Controls.Add(this.textBox3);
            this.groupBoxParcelas.Controls.Add(this.textBox2);
            this.groupBoxParcelas.Controls.Add(this.textBox1);
            this.groupBoxParcelas.Controls.Add(this.radioButton4);
            this.groupBoxParcelas.Controls.Add(this.radioButton3);
            this.groupBoxParcelas.Controls.Add(this.radioButton2);
            this.groupBoxParcelas.Controls.Add(this.radioButton1);
            this.groupBoxParcelas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxParcelas.Location = new System.Drawing.Point(14, 376);
            this.groupBoxParcelas.Name = "groupBoxParcelas";
            this.groupBoxParcelas.Size = new System.Drawing.Size(476, 121);
            this.groupBoxParcelas.TabIndex = 15;
            this.groupBoxParcelas.TabStop = false;
            this.groupBoxParcelas.Text = "PARCELAS";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 33);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 33);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 33);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 33);
            this.textBox1.TabIndex = 4;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(290, 81);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(49, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4x";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(290, 35);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(49, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3x";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(30, 81);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2x";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(30, 35);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1x";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(379, 603);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(101, 32);
            this.buttonLimpar.TabIndex = 53;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(379, 551);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(101, 32);
            this.buttonCalcular.TabIndex = 52;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(343, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "TOTAL";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(302, 290);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(155, 33);
            this.textBoxTotal.TabIndex = 54;
            // 
            // labelResultado
            // 
            this.labelResultado.BackColor = System.Drawing.Color.White;
            this.labelResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResultado.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResultado.Location = new System.Drawing.Point(14, 515);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(350, 153);
            this.labelResultado.TabIndex = 55;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelData,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(502, 22);
            this.statusStrip1.TabIndex = 56;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Hoje é: ";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabel2.Text = "| E são: ";
            // 
            // toolStripStatusLabelHora
            // 
            this.toolStripStatusLabelHora.Name = "toolStripStatusLabelHora";
            this.toolStripStatusLabelHora.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelHora.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabelHora.Click += new System.EventHandler(this.toolStripStatusLabelHora_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.toolStripStatusLabelHora_Click);
            // 
            // Voltar
            // 
            this.Voltar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Voltar.Location = new System.Drawing.Point(5, 6);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(47, 23);
            this.Voltar.TabIndex = 7;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            // 
            // FormFarmacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 701);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBoxParcelas);
            this.Controls.Add(this.groupBoxPagamento);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.textBoxValorUni);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxMedicamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFarmacia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFarmacia";
            this.groupBoxPagamento.ResumeLayout(false);
            this.groupBoxPagamento.PerformLayout();
            this.groupBoxParcelas.ResumeLayout(false);
            this.groupBoxParcelas.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxMedicamento;
        private ComboBox comboBoxMarca;
        private TextBox textBoxQuantidade;
        private TextBox textBoxValorUni;
        private TextBox textBoxSubTotal;
        private GroupBox groupBoxPagamento;
        private RadioButton radioButtonPopular;
        private RadioButton radioButtonCredito;
        private RadioButton radioButtonDinheiro;
        private GroupBox groupBoxParcelas;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button buttonLimpar;
        private Button buttonCalcular;
        private Label label7;
        private TextBox textBoxTotal;
        private Label labelResultado;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelData;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabelHora;
        private System.Windows.Forms.Timer timer1;
        private Button Voltar;
    }
}