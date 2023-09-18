namespace Conversor_de_medidas
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            cmbMed1 = new ComboBox();
            label3 = new Label();
            txtMed = new TextBox();
            cmbMed2 = new ComboBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            btnConvert = new Button();
            btnSair = new Button();
            lbResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 21);
            label1.Name = "label1";
            label1.Size = new Size(133, 39);
            label1.TabIndex = 0;
            label1.Text = "MEDIDAS";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 224);
            label2.Name = "label2";
            label2.Size = new Size(268, 25);
            label2.TabIndex = 2;
            label2.Text = "Selecione o tipo inicial de medida";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(268, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // cmbMed1
            // 
            cmbMed1.FormattingEnabled = true;
            cmbMed1.Items.AddRange(new object[] { "Metros", "Centimetros", "Quilometros" });
            cmbMed1.Location = new Point(12, 281);
            cmbMed1.Name = "cmbMed1";
            cmbMed1.Size = new Size(268, 23);
            cmbMed1.TabIndex = 4;
            cmbMed1.SelectedIndexChanged += cbmMed1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(260, 74);
            label3.Name = "label3";
            label3.Size = new Size(257, 21);
            label3.TabIndex = 5;
            label3.Text = "Qual o numero a ser convertido?";
            label3.Click += label3_Click;
            // 
            // txtMed
            // 
            txtMed.BackColor = SystemColors.ActiveBorder;
            txtMed.BorderStyle = BorderStyle.None;
            txtMed.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtMed.Location = new Point(260, 98);
            txtMed.Name = "txtMed";
            txtMed.Size = new Size(257, 27);
            txtMed.TabIndex = 6;
            txtMed.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbMed2
            // 
            cmbMed2.FormattingEnabled = true;
            cmbMed2.Items.AddRange(new object[] { "Metros", "Centimetros", "Quilometros" });
            cmbMed2.Location = new Point(520, 281);
            cmbMed2.Name = "cmbMed2";
            cmbMed2.Size = new Size(268, 23);
            cmbMed2.TabIndex = 9;
            cmbMed2.SelectedIndexChanged += cmbMed2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(520, 224);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 5, 0);
            label4.Size = new Size(267, 25);
            label4.TabIndex = 7;
            label4.Text = "Selecione o tipo final da medida";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(520, 217);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(268, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.FlatAppearance.BorderColor = Color.Red;
            btnConvert.FlatAppearance.BorderSize = 5;
            btnConvert.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(327, 217);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(131, 87);
            btnConvert.TabIndex = 10;
            btnConvert.Text = "CONVERTER";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(713, 8);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 26);
            btnSair.TabIndex = 12;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lbResultado
            // 
            lbResultado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbResultado.BackColor = Color.LightGray;
            lbResultado.BorderStyle = BorderStyle.Fixed3D;
            lbResultado.FlatStyle = FlatStyle.Popup;
            lbResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbResultado.ImageAlign = ContentAlignment.TopCenter;
            lbResultado.Location = new Point(239, 332);
            lbResultado.Name = "lbResultado";
            lbResultado.Padding = new Padding(20, 0, 20, 0);
            lbResultado.RightToLeft = RightToLeft.No;
            lbResultado.Size = new Size(308, 39);
            lbResultado.TabIndex = 13;
            lbResultado.Text = "Valor convertido:";
            lbResultado.TextAlign = ContentAlignment.BottomCenter;
            lbResultado.Click += lbResultado_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnSair);
            Controls.Add(btnConvert);
            Controls.Add(cmbMed2);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(txtMed);
            Controls.Add(label3);
            Controls.Add(cmbMed1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form2";
            Text = "Medidas";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private ComboBox cmbMed1;
        private Label label3;
        private TextBox txtMed;
        private ComboBox cmbMed2;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btnConvert;
        private Button btnSair;
        private Label lbResultado;
    }
}