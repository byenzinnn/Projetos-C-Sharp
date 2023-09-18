namespace Conversor_de_medidas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnConvert = new Button();
            cmbTemp2 = new ComboBox();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            txtTemp = new TextBox();
            label3 = new Label();
            cmbTemp1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSair = new Button();
            lbResultado2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.FlatAppearance.BorderColor = Color.Red;
            btnConvert.FlatAppearance.BorderSize = 5;
            btnConvert.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(329, 224);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(131, 87);
            btnConvert.TabIndex = 24;
            btnConvert.Text = "CONVERTER";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // cmbTemp2
            // 
            cmbTemp2.FormattingEnabled = true;
            cmbTemp2.Items.AddRange(new object[] { "Grau Celsius", "Farenheit", "Kelvin" });
            cmbTemp2.Location = new Point(522, 288);
            cmbTemp2.Name = "cmbTemp2";
            cmbTemp2.Size = new Size(268, 23);
            cmbTemp2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLight;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(527, 231);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 5, 0);
            label4.Size = new Size(260, 25);
            label4.TabIndex = 21;
            label4.Text = "Selecione o a temperatura final";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(527, 224);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(260, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // txtTemp
            // 
            txtTemp.BackColor = SystemColors.ActiveBorder;
            txtTemp.BorderStyle = BorderStyle.None;
            txtTemp.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtTemp.Location = new Point(262, 141);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(257, 27);
            txtTemp.TabIndex = 20;
            txtTemp.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(262, 117);
            label3.Name = "label3";
            label3.Size = new Size(257, 21);
            label3.TabIndex = 19;
            label3.Text = "Qual o numero a ser convertido?";
            // 
            // cmbTemp1
            // 
            cmbTemp1.FormattingEnabled = true;
            cmbTemp1.Items.AddRange(new object[] { "Grau Celsius", "Farenheit", "Kelvin" });
            cmbTemp1.Location = new Point(14, 288);
            cmbTemp1.Name = "cmbTemp1";
            cmbTemp1.Size = new Size(268, 23);
            cmbTemp1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Symbol", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 231);
            label2.Name = "label2";
            label2.Size = new Size(246, 25);
            label2.TabIndex = 16;
            label2.Text = "Selecione a temperatura inicial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(284, 27);
            label1.Name = "label1";
            label1.Size = new Size(213, 39);
            label1.TabIndex = 14;
            label1.Text = "TEMPERATURAS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(679, 32);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 26;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lbResultado2
            // 
            lbResultado2.AutoSize = true;
            lbResultado2.BackColor = SystemColors.ControlLight;
            lbResultado2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbResultado2.Location = new Point(364, 333);
            lbResultado2.Name = "lbResultado2";
            lbResultado2.Size = new Size(60, 28);
            lbResultado2.TabIndex = 27;
            lbResultado2.Text = "Valor";
            lbResultado2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado2);
            Controls.Add(btnSair);
            Controls.Add(btnConvert);
            Controls.Add(cmbTemp2);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(txtTemp);
            Controls.Add(label3);
            Controls.Add(cmbTemp1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form3";
            Text = "Temperaturas";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConvert;
        private ComboBox cmbTemp2;
        private Label label4;
        private PictureBox pictureBox3;
        private TextBox txtTemp;
        private Label label3;
        private ComboBox cmbTemp1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnSair;
        private Label lbResultado2;
    }
}