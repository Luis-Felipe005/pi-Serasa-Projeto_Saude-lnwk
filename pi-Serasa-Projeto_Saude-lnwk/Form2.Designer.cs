namespace pi_Serasa_Projeto_Saude_lnwk
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
            btnVacina = new Button();
            lblOpcoes = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            painelMeio = new Panel();
            btnCancelar = new Button();
            btnConsulta = new Button();
            btnExame = new Button();
            btnSangue = new Button();
            panel1.SuspendLayout();
            painelMeio.SuspendLayout();
            SuspendLayout();
            // 
            // btnVacina
            // 
            btnVacina.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVacina.Location = new Point(213, 10);
            btnVacina.Name = "btnVacina";
            btnVacina.Size = new Size(178, 39);
            btnVacina.TabIndex = 2;
            btnVacina.Text = "Vacinações";
            btnVacina.UseVisualStyleBackColor = true;
            btnVacina.Click += btnVacina_Click;
            // 
            // lblOpcoes
            // 
            lblOpcoes.AutoSize = true;
            lblOpcoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpcoes.Location = new Point(317, 38);
            lblOpcoes.Name = "lblOpcoes";
            lblOpcoes.Size = new Size(210, 21);
            lblOpcoes.TabIndex = 5;
            lblOpcoes.Text = "VER OPÇÕES DE SERVIÇOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 172, 255);
            panel1.Controls.Add(lblOpcoes);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 100);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(139, 172, 255);
            panel2.Location = new Point(-2, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 100);
            panel2.TabIndex = 7;
            // 
            // painelMeio
            // 
            painelMeio.Controls.Add(btnCancelar);
            painelMeio.Controls.Add(btnConsulta);
            painelMeio.Controls.Add(btnExame);
            painelMeio.Controls.Add(btnSangue);
            painelMeio.Controls.Add(btnVacina);
            painelMeio.Location = new Point(188, 96);
            painelMeio.Name = "painelMeio";
            painelMeio.Size = new Size(400, 265);
            painelMeio.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(114, 223);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(178, 39);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConsulta
            // 
            btnConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsulta.Location = new Point(213, 157);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(178, 39);
            btnConsulta.TabIndex = 5;
            btnConsulta.Text = "Consultas";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnExame
            // 
            btnExame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExame.Location = new Point(14, 157);
            btnExame.Name = "btnExame";
            btnExame.Size = new Size(178, 39);
            btnExame.TabIndex = 4;
            btnExame.Text = "Coleta De Exame";
            btnExame.UseVisualStyleBackColor = true;
            btnExame.Click += btnExame_Click;
            // 
            // btnSangue
            // 
            btnSangue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSangue.Location = new Point(14, 10);
            btnSangue.Name = "btnSangue";
            btnSangue.Size = new Size(178, 39);
            btnSangue.TabIndex = 3;
            btnSangue.Text = "Doação De Sangue";
            btnSangue.UseVisualStyleBackColor = true;
            btnSangue.Click += btnSangue_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(painelMeio);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            painelMeio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnVacina;
        private Label lblOpcoes;
        private Panel panel1;
        private Panel panel2;
        private Panel painelMeio;
        private Button btnCancelar;
        private Button btnConsulta;
        private Button btnExame;
        private Button btnSangue;
    }
}