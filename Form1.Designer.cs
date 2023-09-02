namespace Conversor_de_medidas_e_velocidades
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
            gbConvMed = new GroupBox();
            lbResultado = new Label();
            btnQuilometros = new Button();
            btnCentimetros = new Button();
            label1 = new Label();
            btnMetros = new Button();
            icon1 = new PictureBox();
            txtVal1 = new TextBox();
            lbVal1 = new Label();
            gbConvMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            SuspendLayout();
            // 
            // gbConvMed
            // 
            gbConvMed.Controls.Add(lbResultado);
            gbConvMed.Controls.Add(btnQuilometros);
            gbConvMed.Controls.Add(btnCentimetros);
            gbConvMed.Controls.Add(label1);
            gbConvMed.Controls.Add(btnMetros);
            gbConvMed.Controls.Add(icon1);
            gbConvMed.Controls.Add(txtVal1);
            gbConvMed.Controls.Add(lbVal1);
            gbConvMed.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            gbConvMed.Location = new Point(12, 12);
            gbConvMed.Name = "gbConvMed";
            gbConvMed.Size = new Size(323, 279);
            gbConvMed.TabIndex = 0;
            gbConvMed.TabStop = false;
            gbConvMed.Text = "CONVERSOR DE MEDIDAS";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(23, 227);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(106, 28);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            lbResultado.Click += label2_Click;
            // 
            // btnQuilometros
            // 
            btnQuilometros.BackColor = SystemColors.ControlLight;
            btnQuilometros.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuilometros.Location = new Point(23, 159);
            btnQuilometros.Name = "btnQuilometros";
            btnQuilometros.Size = new Size(105, 43);
            btnQuilometros.TabIndex = 6;
            btnQuilometros.Text = "Quilometros";
            btnQuilometros.UseVisualStyleBackColor = false;
            btnQuilometros.Click += btnQuilometros_Click;
            // 
            // btnCentimetros
            // 
            btnCentimetros.BackColor = SystemColors.ControlLight;
            btnCentimetros.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCentimetros.Location = new Point(212, 159);
            btnCentimetros.Name = "btnCentimetros";
            btnCentimetros.Size = new Size(105, 43);
            btnCentimetros.TabIndex = 5;
            btnCentimetros.Text = "Centimetros";
            btnCentimetros.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 113);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 4;
            label1.Text = "Você quer converter para?";
            // 
            // btnMetros
            // 
            btnMetros.BackColor = SystemColors.ControlLight;
            btnMetros.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMetros.Location = new Point(134, 159);
            btnMetros.Name = "btnMetros";
            btnMetros.Size = new Size(72, 43);
            btnMetros.TabIndex = 3;
            btnMetros.Text = "Metros";
            btnMetros.UseVisualStyleBackColor = false;
            // 
            // icon1
            // 
            icon1.Image = (Image)resources.GetObject("icon1.Image");
            icon1.Location = new Point(252, 210);
            icon1.Name = "icon1";
            icon1.Size = new Size(65, 63);
            icon1.SizeMode = PictureBoxSizeMode.StretchImage;
            icon1.TabIndex = 2;
            icon1.TabStop = false;
            icon1.Click += icon1_Click;
            // 
            // txtVal1
            // 
            txtVal1.Location = new Point(84, 50);
            txtVal1.Name = "txtVal1";
            txtVal1.Size = new Size(200, 34);
            txtVal1.TabIndex = 1;
            // 
            // lbVal1
            // 
            lbVal1.AutoSize = true;
            lbVal1.Location = new Point(6, 53);
            lbVal1.Name = "lbVal1";
            lbVal1.Size = new Size(60, 28);
            lbVal1.TabIndex = 0;
            lbVal1.Text = "Valor";
            lbVal1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbConvMed);
            Name = "Form1";
            Text = "Conversor de medidas/velocidades";
            gbConvMed.ResumeLayout(false);
            gbConvMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)icon1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbConvMed;
        private Label lbVal1;
        private TextBox txtVal1;
        private Button btnMetros;
        private PictureBox icon1;
        private Label label1;
        private Label lbResultado;
        private Button btnQuilometros;
        private Button btnCentimetros;
    }
}