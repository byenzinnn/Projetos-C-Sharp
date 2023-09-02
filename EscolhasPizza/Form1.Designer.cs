namespace EscolhasPizza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbFormaPagamento = new ComboBox();
            lbFormaPagamento = new Label();
            lbPizzas = new Label();
            chkCalabresa = new CheckBox();
            chk4Queijos = new CheckBox();
            chkPortuguesa = new CheckBox();
            chkBacon = new CheckBox();
            lbBebidas = new Label();
            chkRefrigerante = new CheckBox();
            chkCafé = new CheckBox();
            chkAgua = new CheckBox();
            chkSuco = new CheckBox();
            cmbAdicional = new ComboBox();
            groupBox1 = new GroupBox();
            lbPagamento = new Label();
            lbBebida = new Label();
            lbAdicional = new Label();
            lbPizza = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            chkLimparBebida = new CheckBox();
            chkLimparPizza = new CheckBox();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            button1 = new Button();
            icon1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            icon2 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "Debito", "Credito", "Pix", "Boleto" });
            cmbFormaPagamento.Location = new Point(12, 322);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(154, 23);
            cmbFormaPagamento.TabIndex = 0;
            cmbFormaPagamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lbFormaPagamento
            // 
            lbFormaPagamento.AutoSize = true;
            lbFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbFormaPagamento.Location = new Point(12, 300);
            lbFormaPagamento.Name = "lbFormaPagamento";
            lbFormaPagamento.Size = new Size(154, 19);
            lbFormaPagamento.TabIndex = 1;
            lbFormaPagamento.Text = "FORMA PAGAMENTO:";
            // 
            // lbPizzas
            // 
            lbPizzas.AutoSize = true;
            lbPizzas.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbPizzas.Location = new Point(11, 21);
            lbPizzas.Name = "lbPizzas";
            lbPizzas.Size = new Size(79, 28);
            lbPizzas.TabIndex = 2;
            lbPizzas.Text = "PIZZAS";
            // 
            // chkCalabresa
            // 
            chkCalabresa.AutoSize = true;
            chkCalabresa.Location = new Point(11, 63);
            chkCalabresa.Name = "chkCalabresa";
            chkCalabresa.Size = new Size(94, 23);
            chkCalabresa.TabIndex = 3;
            chkCalabresa.Text = "Calabresa";
            chkCalabresa.UseVisualStyleBackColor = true;
            chkCalabresa.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chk4Queijos
            // 
            chk4Queijos.AutoSize = true;
            chk4Queijos.Location = new Point(11, 88);
            chk4Queijos.Name = "chk4Queijos";
            chk4Queijos.Size = new Size(90, 23);
            chk4Queijos.TabIndex = 4;
            chk4Queijos.Text = "4 Queijos";
            chk4Queijos.UseVisualStyleBackColor = true;
            chk4Queijos.CheckedChanged += chk4Queijos_CheckedChanged;
            // 
            // chkPortuguesa
            // 
            chkPortuguesa.AutoSize = true;
            chkPortuguesa.Location = new Point(11, 113);
            chkPortuguesa.Name = "chkPortuguesa";
            chkPortuguesa.Size = new Size(104, 23);
            chkPortuguesa.TabIndex = 5;
            chkPortuguesa.Text = "Portuguesa";
            chkPortuguesa.UseVisualStyleBackColor = true;
            chkPortuguesa.CheckedChanged += chkPortuguesa_CheckedChanged;
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(11, 138);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(69, 23);
            chkBacon.TabIndex = 6;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            chkBacon.CheckedChanged += chkBacon_CheckedChanged;
            // 
            // lbBebidas
            // 
            lbBebidas.AutoSize = true;
            lbBebidas.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbBebidas.Location = new Point(177, 21);
            lbBebidas.Name = "lbBebidas";
            lbBebidas.Size = new Size(95, 28);
            lbBebidas.TabIndex = 7;
            lbBebidas.Text = "BEBIDAS";
            // 
            // chkRefrigerante
            // 
            chkRefrigerante.AutoSize = true;
            chkRefrigerante.Location = new Point(177, 63);
            chkRefrigerante.Name = "chkRefrigerante";
            chkRefrigerante.Size = new Size(112, 23);
            chkRefrigerante.TabIndex = 8;
            chkRefrigerante.Text = "Refrigerante";
            chkRefrigerante.UseVisualStyleBackColor = true;
            chkRefrigerante.CheckedChanged += chkRefrigerante_CheckedChanged;
            // 
            // chkCafé
            // 
            chkCafé.AutoSize = true;
            chkCafé.Location = new Point(177, 88);
            chkCafé.Name = "chkCafé";
            chkCafé.Size = new Size(58, 23);
            chkCafé.TabIndex = 9;
            chkCafé.Text = "Café";
            chkCafé.UseVisualStyleBackColor = true;
            chkCafé.CheckedChanged += chkCafé_CheckedChanged;
            // 
            // chkAgua
            // 
            chkAgua.AutoSize = true;
            chkAgua.Location = new Point(177, 113);
            chkAgua.Name = "chkAgua";
            chkAgua.Size = new Size(63, 23);
            chkAgua.TabIndex = 10;
            chkAgua.Text = "Água";
            chkAgua.UseVisualStyleBackColor = true;
            chkAgua.CheckedChanged += chkAgua_CheckedChanged;
            // 
            // chkSuco
            // 
            chkSuco.AutoSize = true;
            chkSuco.Location = new Point(177, 138);
            chkSuco.Name = "chkSuco";
            chkSuco.Size = new Size(60, 23);
            chkSuco.TabIndex = 11;
            chkSuco.Text = "Suco";
            chkSuco.UseVisualStyleBackColor = true;
            chkSuco.CheckedChanged += chkSuco_CheckedChanged;
            // 
            // cmbAdicional
            // 
            cmbAdicional.FormattingEnabled = true;
            cmbAdicional.Items.AddRange(new object[] { "Cebola", "Borda recheada", "Batata frita" });
            cmbAdicional.Location = new Point(12, 268);
            cmbAdicional.Name = "cmbAdicional";
            cmbAdicional.Size = new Size(121, 23);
            cmbAdicional.TabIndex = 13;
            cmbAdicional.SelectedIndexChanged += cmbAdicional_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(lbPagamento);
            groupBox1.Controls.Add(lbBebida);
            groupBox1.Controls.Add(lbAdicional);
            groupBox1.Controls.Add(lbPizza);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(444, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 123);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "ESCOLHAS";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPagamento.Location = new Point(56, 93);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(0, 19);
            lbPagamento.TabIndex = 7;
            // 
            // lbBebida
            // 
            lbBebida.AutoSize = true;
            lbBebida.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbBebida.Location = new Point(74, 75);
            lbBebida.Name = "lbBebida";
            lbBebida.Size = new Size(0, 19);
            lbBebida.TabIndex = 6;
            // 
            // lbAdicional
            // 
            lbAdicional.AutoSize = true;
            lbAdicional.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdicional.Location = new Point(90, 55);
            lbAdicional.Name = "lbAdicional";
            lbAdicional.Size = new Size(0, 19);
            lbAdicional.TabIndex = 5;
            // 
            // lbPizza
            // 
            lbPizza.AutoSize = true;
            lbPizza.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbPizza.Location = new Point(62, 36);
            lbPizza.Name = "lbPizza";
            lbPizza.Size = new Size(0, 19);
            lbPizza.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 93);
            label4.Name = "label4";
            label4.Size = new Size(45, 19);
            label4.TabIndex = 3;
            label4.Text = "Pgto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 74);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 2;
            label3.Text = "Bebida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 55);
            label2.Name = "label2";
            label2.Size = new Size(76, 19);
            label2.TabIndex = 1;
            label2.Text = "Adicional:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 36);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Pizza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 246);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 15;
            label5.Text = "ADICIONAIS";
            // 
            // chkLimparBebida
            // 
            chkLimparBebida.AutoSize = true;
            chkLimparBebida.Location = new Point(177, 164);
            chkLimparBebida.Name = "chkLimparBebida";
            chkLimparBebida.Size = new Size(75, 23);
            chkLimparBebida.TabIndex = 16;
            chkLimparBebida.Text = "Limpar";
            chkLimparBebida.UseVisualStyleBackColor = true;
            chkLimparBebida.CheckedChanged += chkLimparBebida_CheckedChanged;
            // 
            // chkLimparPizza
            // 
            chkLimparPizza.AutoSize = true;
            chkLimparPizza.Location = new Point(11, 164);
            chkLimparPizza.Name = "chkLimparPizza";
            chkLimparPizza.Size = new Size(75, 23);
            chkLimparPizza.TabIndex = 17;
            chkLimparPizza.Text = "Limpar";
            chkLimparPizza.UseVisualStyleBackColor = true;
            chkLimparPizza.CheckedChanged += chkLimparPizza_CheckedChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(62, 348);
            maskedTextBox1.Mask = "999.999.999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(90, 23);
            maskedTextBox1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(518, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(518, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 159);
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(518, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(275, 162);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(518, 150);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(275, 162);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 351);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 23;
            label6.Text = "CPF:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 390);
            button1.Name = "button1";
            button1.Size = new Size(108, 49);
            button1.TabIndex = 24;
            button1.Text = "SAIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // icon1
            // 
            icon1.Image = (Image)resources.GetObject("icon1.Image");
            icon1.Location = new Point(126, 390);
            icon1.Name = "icon1";
            icon1.Size = new Size(40, 48);
            icon1.SizeMode = PictureBoxSizeMode.StretchImage;
            icon1.TabIndex = 25;
            icon1.TabStop = false;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // icon2
            // 
            icon2.Image = (Image)resources.GetObject("icon2.Image");
            icon2.Location = new Point(383, 370);
            icon2.Name = "icon2";
            icon2.Size = new Size(55, 68);
            icon2.SizeMode = PictureBoxSizeMode.StretchImage;
            icon2.TabIndex = 26;
            icon2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbPizzas);
            groupBox2.Controls.Add(chkCalabresa);
            groupBox2.Controls.Add(chk4Queijos);
            groupBox2.Controls.Add(chkPortuguesa);
            groupBox2.Controls.Add(chkBacon);
            groupBox2.Controls.Add(lbBebidas);
            groupBox2.Controls.Add(chkRefrigerante);
            groupBox2.Controls.Add(chkCafé);
            groupBox2.Controls.Add(chkAgua);
            groupBox2.Controls.Add(chkSuco);
            groupBox2.Controls.Add(chkLimparBebida);
            groupBox2.Controls.Add(chkLimparPizza);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(302, 215);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "ESCOLHAS";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(icon2);
            Controls.Add(icon1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(cmbAdicional);
            Controls.Add(lbFormaPagamento);
            Controls.Add(cmbFormaPagamento);
            Name = "Form1";
            Text = "ESCOLHAS";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFormaPagamento;
        private Label lbFormaPagamento;
        private Label lbPizzas;
        private CheckBox chkCalabresa;
        private CheckBox chk4Queijos;
        private CheckBox chkPortuguesa;
        private CheckBox chkBacon;
        private Label lbBebidas;
        private CheckBox chkRefrigerante;
        private CheckBox chkCafé;
        private CheckBox chkAgua;
        private CheckBox chkSuco;
        private ComboBox cmbAdicional;
        private GroupBox groupBox1;
        private Label lbPizza;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lbBebida;
        private Label lbAdicional;
        private Label lbPagamento;
        private CheckBox chkLimparBebida;
        private CheckBox chkLimparPizza;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label6;
        private Button button1;
        private PictureBox icon1;
        private ToolTip toolTip1;
        private PictureBox icon2;
        private GroupBox groupBox2;
    }
}