namespace Software_Trelisa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCriar = new System.Windows.Forms.RadioButton();
            this.rbDeletar = new System.Windows.Forms.RadioButton();
            this.rbBarras = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtVisualiza = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDesenha = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(201, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 607);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.rbCriar);
            this.panel2.Controls.Add(this.rbDeletar);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(12, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 153);
            this.panel2.TabIndex = 0;
            // 
            // rbCriar
            // 
            this.rbCriar.AutoSize = true;
            this.rbCriar.Location = new System.Drawing.Point(14, 35);
            this.rbCriar.Name = "rbCriar";
            this.rbCriar.Size = new System.Drawing.Size(74, 32);
            this.rbCriar.TabIndex = 0;
            this.rbCriar.TabStop = true;
            this.rbCriar.Text = "Criar";
            this.rbCriar.UseVisualStyleBackColor = true;
            // 
            // rbDeletar
            // 
            this.rbDeletar.AutoSize = true;
            this.rbDeletar.Location = new System.Drawing.Point(14, 88);
            this.rbDeletar.Name = "rbDeletar";
            this.rbDeletar.Size = new System.Drawing.Size(96, 32);
            this.rbDeletar.TabIndex = 1;
            this.rbDeletar.TabStop = true;
            this.rbDeletar.Text = "Deletar";
            this.rbDeletar.UseVisualStyleBackColor = true;
            // 
            // rbBarras
            // 
            this.rbBarras.AutoSize = true;
            this.rbBarras.Location = new System.Drawing.Point(14, 35);
            this.rbBarras.Name = "rbBarras";
            this.rbBarras.Size = new System.Drawing.Size(86, 32);
            this.rbBarras.TabIndex = 2;
            this.rbBarras.TabStop = true;
            this.rbBarras.Text = "Barras";
            this.rbBarras.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.rbBarras);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(12, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 247);
            this.panel3.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 32);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Apoios";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 32);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Forças";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtVisualiza
            // 
            this.txtVisualiza.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVisualiza.Location = new System.Drawing.Point(26, 582);
            this.txtVisualiza.Name = "txtVisualiza";
            this.txtVisualiza.ReadOnly = true;
            this.txtVisualiza.Size = new System.Drawing.Size(141, 27);
            this.txtVisualiza.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(42, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDesenha
            // 
            this.btnDesenha.Location = new System.Drawing.Point(42, 10);
            this.btnDesenha.Name = "btnDesenha";
            this.btnDesenha.Size = new System.Drawing.Size(94, 29);
            this.btnDesenha.TabIndex = 0;
            this.btnDesenha.Text = "Desenha";
            this.btnDesenha.UseVisualStyleBackColor = true;
            this.btnDesenha.Click += new System.EventHandler(this.btnDesenha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 631);
            this.Controls.Add(this.btnDesenha);
            this.Controls.Add(this.txtVisualiza);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private RadioButton rbCriar;
        private RadioButton rbDeletar;
        private RadioButton rbBarras;
        private Panel panel3;
        private TextBox txtVisualiza;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button1;
        private Button btnDesenha;
    }
}