namespace ProjetoSurpresa
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
            this.btnCalcularVenus = new System.Windows.Forms.Button();
            this.btnCalcularJupiter = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.btnCalcularMarte = new System.Windows.Forms.Button();
            this.txtPesoTerra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcularVenus
            // 
            this.btnCalcularVenus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcularVenus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularVenus.Location = new System.Drawing.Point(125, 184);
            this.btnCalcularVenus.Name = "btnCalcularVenus";
            this.btnCalcularVenus.Size = new System.Drawing.Size(102, 65);
            this.btnCalcularVenus.TabIndex = 17;
            this.btnCalcularVenus.Text = "Calcular o peso em Vênus";
            this.btnCalcularVenus.UseVisualStyleBackColor = false;
            this.btnCalcularVenus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularJupiter
            // 
            this.btnCalcularJupiter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcularJupiter.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularJupiter.Location = new System.Drawing.Point(17, 255);
            this.btnCalcularJupiter.Name = "btnCalcularJupiter";
            this.btnCalcularJupiter.Size = new System.Drawing.Size(102, 65);
            this.btnCalcularJupiter.TabIndex = 16;
            this.btnCalcularJupiter.Text = "Calcular o peso em Júpiter";
            this.btnCalcularJupiter.UseVisualStyleBackColor = false;
            this.btnCalcularJupiter.Click += new System.EventHandler(this.btnCalcularJupiter_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(123, 338);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 30);
            this.label.TabIndex = 15;
            this.label.Text = "Resultado:";
            // 
            // btnCalcularMarte
            // 
            this.btnCalcularMarte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalcularMarte.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcularMarte.Location = new System.Drawing.Point(17, 184);
            this.btnCalcularMarte.Name = "btnCalcularMarte";
            this.btnCalcularMarte.Size = new System.Drawing.Size(102, 65);
            this.btnCalcularMarte.TabIndex = 14;
            this.btnCalcularMarte.Text = "Calcular o peso em marte";
            this.btnCalcularMarte.UseVisualStyleBackColor = false;
            this.btnCalcularMarte.Click += new System.EventHandler(this.btnCalcularMarte_Click);
            // 
            // txtPesoTerra
            // 
            this.txtPesoTerra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesoTerra.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPesoTerra.Location = new System.Drawing.Point(17, 118);
            this.txtPesoTerra.Name = "txtPesoTerra";
            this.txtPesoTerra.Size = new System.Drawing.Size(243, 27);
            this.txtPesoTerra.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o peso na terra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Peso em planetas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(66, 375);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(37, 28);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = ".....";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(125, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 65);
            this.button1.TabIndex = 19;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(385, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 65);
            this.button2.TabIndex = 20;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(385, 63);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 65);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "Retornar ao menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularVenus);
            this.Controls.Add(this.btnCalcularJupiter);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnCalcularMarte);
            this.Controls.Add(this.txtPesoTerra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form2";
            this.Text = "Calculadora de peso nos planetas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcularVenus;
        private Button btnCalcularJupiter;
        private Label label;
        private Button btnCalcularMarte;
        private TextBox txtPesoTerra;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblResultado;
        private Button button1;
        private Button button2;
        private Button btnReturn;
    }
}