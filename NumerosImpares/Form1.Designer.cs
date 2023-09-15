namespace NumerosImpares
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
            label1 = new Label();
            label2 = new Label();
            txbVal = new TextBox();
            ltbNumeros = new ListBox();
            btnCalcular = new Button();
            button1 = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 39);
            label1.TabIndex = 0;
            label1.Text = "NUMEROS IMPARES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(203, 28);
            label2.TabIndex = 1;
            label2.Text = "INSIRA UM NUMERO:";
            // 
            // txbVal
            // 
            txbVal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txbVal.Location = new Point(12, 134);
            txbVal.Name = "txbVal";
            txbVal.Size = new Size(199, 34);
            txbVal.TabIndex = 2;
            // 
            // ltbNumeros
            // 
            ltbNumeros.FormattingEnabled = true;
            ltbNumeros.ItemHeight = 15;
            ltbNumeros.Location = new Point(289, 92);
            ltbNumeros.Name = "ltbNumeros";
            ltbNumeros.Size = new Size(337, 154);
            ltbNumeros.TabIndex = 3;
            ltbNumeros.SelectedIndexChanged += ltbNumeros_SelectedIndexChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(12, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 96);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Mostrar Numeros";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(149, 228);
            button1.Name = "button1";
            button1.Size = new Size(114, 96);
            button1.TabIndex = 5;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(12, 342);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(110, 96);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(button1);
            Controls.Add(btnCalcular);
            Controls.Add(ltbNumeros);
            Controls.Add(txbVal);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbVal;
        private ListBox ltbNumeros;
        private Button btnCalcular;
        private Button button1;
        private Button btnLimpar;
    }
}