namespace ProjetoTabuada
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
            lbTabuada = new Label();
            btnTabuada = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            ltbTabuada = new ListBox();
            lbNum = new Label();
            txbNum = new TextBox();
            SuspendLayout();
            // 
            // lbTabuada
            // 
            lbTabuada.AutoSize = true;
            lbTabuada.BackColor = Color.CornflowerBlue;
            lbTabuada.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbTabuada.Location = new Point(104, 45);
            lbTabuada.Name = "lbTabuada";
            lbTabuada.Size = new Size(126, 37);
            lbTabuada.TabIndex = 0;
            lbTabuada.Text = "Tabuada";
            // 
            // btnTabuada
            // 
            btnTabuada.BackColor = Color.CornflowerBlue;
            btnTabuada.Location = new Point(104, 195);
            btnTabuada.Name = "btnTabuada";
            btnTabuada.Size = new Size(117, 40);
            btnTabuada.TabIndex = 1;
            btnTabuada.Text = "TABUADA";
            btnTabuada.UseVisualStyleBackColor = false;
            btnTabuada.Click += btnTabuada_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.CornflowerBlue;
            btnLimpar.Location = new Point(104, 241);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(117, 40);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.CornflowerBlue;
            btnSair.Location = new Point(104, 287);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(117, 40);
            btnSair.TabIndex = 3;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // ltbTabuada
            // 
            ltbTabuada.FormattingEnabled = true;
            ltbTabuada.ItemHeight = 15;
            ltbTabuada.Location = new Point(246, 113);
            ltbTabuada.Name = "ltbTabuada";
            ltbTabuada.Size = new Size(176, 214);
            ltbTabuada.TabIndex = 4;
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbNum.Location = new Point(239, 50);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(84, 28);
            lbNum.TabIndex = 5;
            lbNum.Text = "Numero";
            lbNum.Click += label2_Click;
            // 
            // txbNum
            // 
            txbNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txbNum.Location = new Point(331, 53);
            txbNum.Name = "txbNum";
            txbNum.Size = new Size(100, 29);
            txbNum.TabIndex = 6;
            txbNum.TextChanged += txtNum_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txbNum);
            Controls.Add(lbNum);
            Controls.Add(ltbTabuada);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnTabuada);
            Controls.Add(lbTabuada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTabuada;
        private Button btnTabuada;
        private Button btnLimpar;
        private Button btnSair;
        private ListBox ltbTabuada;
        private Label lbNum;
        private TextBox txbNum;
    }
}