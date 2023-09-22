namespace ProjetoSurpresa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMed1 = new System.Windows.Forms.ComboBox();
            this.cmbMed2 = new System.Windows.Forms.ComboBox();
            this.lbConvertDe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(225, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retornar ao menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(225, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Conversor de medidas";
            // 
            // cmbMed1
            // 
            this.cmbMed1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMed1.FormattingEnabled = true;
            this.cmbMed1.Items.AddRange(new object[] {
            "Metros",
            "Centimetros",
            "Quilometros"});
            this.cmbMed1.Location = new System.Drawing.Point(12, 226);
            this.cmbMed1.Name = "cmbMed1";
            this.cmbMed1.Size = new System.Drawing.Size(158, 36);
            this.cmbMed1.TabIndex = 3;
            // 
            // cmbMed2
            // 
            this.cmbMed2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMed2.FormattingEnabled = true;
            this.cmbMed2.Items.AddRange(new object[] {
            "Metros",
            "Centimetros",
            "Quilometros"});
            this.cmbMed2.Location = new System.Drawing.Point(12, 316);
            this.cmbMed2.Name = "cmbMed2";
            this.cmbMed2.Size = new System.Drawing.Size(158, 36);
            this.cmbMed2.TabIndex = 4;
            // 
            // lbConvertDe
            // 
            this.lbConvertDe.AutoSize = true;
            this.lbConvertDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConvertDe.Location = new System.Drawing.Point(12, 197);
            this.lbConvertDe.Name = "lbConvertDe";
            this.lbConvertDe.Size = new System.Drawing.Size(129, 28);
            this.lbConvertDe.TabIndex = 5;
            this.lbConvertDe.Text = "Converter de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "para :";
            // 
            // txtMed
            // 
            this.txtMed.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMed.Location = new System.Drawing.Point(12, 111);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(178, 34);
            this.txtMed.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Digite aqui o valor:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResultado.Location = new System.Drawing.Point(225, 111);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(102, 28);
            this.lbResultado.TabIndex = 9;
            this.lbResultado.Text = "Resultado:";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(12, 377);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(158, 48);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConvertDe);
            this.Controls.Add(this.cmbMed2);
            this.Controls.Add(this.cmbMed1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Conversor de medidas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox cmbMed1;
        private ComboBox cmbMed2;
        private Label lbConvertDe;
        private Label label2;
        private TextBox txtMed;
        private Label label3;
        private Label lbResultado;
        private Button btnConvert;
    }
}