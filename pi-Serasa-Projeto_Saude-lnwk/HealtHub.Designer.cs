namespace pi_Serasa_Projeto_Saude_lnwk
{
    partial class HealtHub
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
            this.lblBemvindo = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.painelMeio = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.painelMeio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBemvindo
            // 
            this.lblBemvindo.AutoSize = true;
            this.lblBemvindo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBemvindo.ForeColor = System.Drawing.Color.White;
            this.lblBemvindo.Location = new System.Drawing.Point(235, 83);
            this.lblBemvindo.Name = "lblBemvindo";
            this.lblBemvindo.Size = new System.Drawing.Size(832, 86);
            this.lblBemvindo.TabIndex = 0;
            this.lblBemvindo.Text = "Bem-Vindo ao Health Hub";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(66, 37);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(256, 23);
            this.txtCpf.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(66, 84);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(256, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // painelMeio
            // 
            this.painelMeio.Controls.Add(this.button1);
            this.painelMeio.Controls.Add(this.txtCpf);
            this.painelMeio.Controls.Add(this.label2);
            this.painelMeio.Controls.Add(this.label3);
            this.painelMeio.Controls.Add(this.txtSenha);
            this.painelMeio.Location = new System.Drawing.Point(225, 195);
            this.painelMeio.Name = "painelMeio";
            this.painelMeio.Size = new System.Drawing.Size(364, 175);
            this.painelMeio.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // HealtHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelMeio);
            this.Controls.Add(this.lblBemvindo);
            this.Name = "HealtHub";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HealtHub_Load);
            this.painelMeio.ResumeLayout(false);
            this.painelMeio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBemvindo;
        private TextBox txtCpf;
        private TextBox txtSenha;
        private Label label2;
        private Label label3;
        private Panel painelMeio;
        private Button button1;
    }
}