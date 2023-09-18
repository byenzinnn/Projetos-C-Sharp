namespace Conversor_de_medidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMedidas = new Button();
            pictureBox3 = new PictureBox();
            btnTemperatura = new Button();
            pictureBox4 = new PictureBox();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.PanSW;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 125);
            label1.Name = "label1";
            label1.Size = new Size(384, 39);
            label1.TabIndex = 0;
            label1.Text = "Escolha o tipo de conversão:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(206, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 10);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(206, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 11);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnMedidas
            // 
            btnMedidas.BackColor = SystemColors.ControlLight;
            btnMedidas.BackgroundImage = (Image)resources.GetObject("btnMedidas.BackgroundImage");
            btnMedidas.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMedidas.ForeColor = Color.Transparent;
            btnMedidas.Location = new Point(406, 219);
            btnMedidas.Name = "btnMedidas";
            btnMedidas.Size = new Size(191, 85);
            btnMedidas.TabIndex = 3;
            btnMedidas.Text = "MEDIDAS";
            btnMedidas.UseVisualStyleBackColor = false;
            btnMedidas.Click += btnMedidas_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(397, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(209, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnTemperatura
            // 
            btnTemperatura.BackColor = SystemColors.ControlLight;
            btnTemperatura.BackgroundImage = (Image)resources.GetObject("btnTemperatura.BackgroundImage");
            btnTemperatura.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTemperatura.ForeColor = Color.Transparent;
            btnTemperatura.Location = new Point(200, 219);
            btnTemperatura.Name = "btnTemperatura";
            btnTemperatura.Size = new Size(191, 85);
            btnTemperatura.TabIndex = 5;
            btnTemperatura.Text = "TEMPERATURA";
            btnTemperatura.UseVisualStyleBackColor = false;
            btnTemperatura.Click += btnTemperatura_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(191, 211);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(209, 105);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.Location = new Point(679, 411);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(109, 27);
            btnSair.TabIndex = 7;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnTemperatura);
            Controls.Add(pictureBox4);
            Controls.Add(btnMedidas);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Conversor de Medidas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Button btnMedidas;
        private PictureBox pictureBox3;
        public Button btnTemperatura;
        private PictureBox pictureBox4;
        private Button btnSair;
    }
}