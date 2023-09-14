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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelCima = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCima = new System.Windows.Forms.Label();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnVacina = new System.Windows.Forms.Button();
            this.btnExame = new System.Windows.Forms.Button();
            this.btnSangue = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEsquerdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCima
            // 
            this.panelCima.BackColor = System.Drawing.Color.Navy;
            this.panelCima.Controls.Add(this.pictureBox1);
            this.panelCima.Controls.Add(this.labelCima);
            this.panelCima.Location = new System.Drawing.Point(0, 1);
            this.panelCima.Name = "panelCima";
            this.panelCima.Size = new System.Drawing.Size(803, 100);
            this.panelCima.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(522, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCima
            // 
            this.labelCima.AutoSize = true;
            this.labelCima.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCima.ForeColor = System.Drawing.Color.White;
            this.labelCima.Location = new System.Drawing.Point(29, 21);
            this.labelCima.Name = "labelCima";
            this.labelCima.Size = new System.Drawing.Size(322, 40);
            this.labelCima.TabIndex = 0;
            this.labelCima.Text = "Ver Opções de Serviço";
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.Navy;
            this.panelEsquerdo.Controls.Add(this.btnConsulta);
            this.panelEsquerdo.Controls.Add(this.btnVacina);
            this.panelEsquerdo.Controls.Add(this.btnExame);
            this.panelEsquerdo.Controls.Add(this.btnSangue);
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 98);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(200, 352);
            this.panelEsquerdo.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(62, 280);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(87, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // btnVacina
            // 
            this.btnVacina.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVacina.ForeColor = System.Drawing.Color.White;
            this.btnVacina.Location = new System.Drawing.Point(62, 199);
            this.btnVacina.Name = "btnVacina";
            this.btnVacina.Size = new System.Drawing.Size(87, 23);
            this.btnVacina.TabIndex = 0;
            this.btnVacina.Text = "Vacinação";
            this.btnVacina.UseVisualStyleBackColor = false;
            // 
            // btnExame
            // 
            this.btnExame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExame.ForeColor = System.Drawing.Color.White;
            this.btnExame.Location = new System.Drawing.Point(62, 135);
            this.btnExame.Name = "btnExame";
            this.btnExame.Size = new System.Drawing.Size(100, 23);
            this.btnExame.TabIndex = 0;
            this.btnExame.Text = "Coletar Exame";
            this.btnExame.UseVisualStyleBackColor = false;
            // 
            // btnSangue
            // 
            this.btnSangue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSangue.ForeColor = System.Drawing.Color.White;
            this.btnSangue.Location = new System.Drawing.Point(62, 66);
            this.btnSangue.Name = "btnSangue";
            this.btnSangue.Size = new System.Drawing.Size(100, 23);
            this.btnSangue.TabIndex = 0;
            this.btnSangue.Text = "Doar Sangue";
            this.btnSangue.UseVisualStyleBackColor = false;
            this.btnSangue.Click += new System.EventHandler(this.btnSangue_Click_1);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelFundo.Location = new System.Drawing.Point(226, 128);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(827, 523);
            this.panelFundo.TabIndex = 2;
            this.panelFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundo_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelCima);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelCima.ResumeLayout(false);
            this.panelCima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEsquerdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCima;
        private Label labelCima;
        private Panel panelEsquerdo;
        private Button btnConsulta;
        private Button btnVacina;
        private Button btnExame;
        private Button btnSangue;
        private Panel panelFundo;
        private PictureBox pictureBox1;
    }
}