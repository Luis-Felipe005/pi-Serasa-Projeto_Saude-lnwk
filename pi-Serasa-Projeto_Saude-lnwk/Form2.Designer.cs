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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelCima = new System.Windows.Forms.Label();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar1 = new System.Windows.Forms.Button();
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnVacina1 = new System.Windows.Forms.Button();
            this.btnExame1 = new System.Windows.Forms.Button();
            this.btnSangue1 = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelEsquerdo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCima
            // 
            this.panelCima.BackColor = System.Drawing.Color.Navy;
            this.panelCima.Controls.Add(this.pictureBox2);
            this.panelCima.Location = new System.Drawing.Point(201, 1);
            this.panelCima.Name = "panelCima";
            this.panelCima.Size = new System.Drawing.Size(1018, 160);
            this.panelCima.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(420, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // labelCima
            // 
            this.labelCima.AutoSize = true;
            this.labelCima.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCima.ForeColor = System.Drawing.Color.White;
            this.labelCima.Location = new System.Drawing.Point(12, 153);
            this.labelCima.Name = "labelCima";
            this.labelCima.Size = new System.Drawing.Size(177, 50);
            this.labelCima.TabIndex = 0;
            this.labelCima.Text = "Serviços:";
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.Navy;
            this.panelEsquerdo.Controls.Add(this.labelCima);
            this.panelEsquerdo.Controls.Add(this.panel1);
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 1);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(202, 804);
            this.panelEsquerdo.TabIndex = 1;
            this.panelEsquerdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEsquerdo_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCancelar1);
            this.panel1.Controls.Add(this.btnConsulta1);
            this.panel1.Controls.Add(this.btnVacina1);
            this.panel1.Controls.Add(this.btnExame1);
            this.panel1.Controls.Add(this.btnSangue1);
            this.panel1.Location = new System.Drawing.Point(29, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 526);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar1
            // 
            this.btnCancelar1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar1.ForeColor = System.Drawing.Color.White;
            this.btnCancelar1.Location = new System.Drawing.Point(9, 440);
            this.btnCancelar1.Name = "btnCancelar1";
            this.btnCancelar1.Size = new System.Drawing.Size(130, 66);
            this.btnCancelar1.TabIndex = 6;
            this.btnCancelar1.Text = "Cancelar";
            this.btnCancelar1.UseVisualStyleBackColor = false;
            this.btnCancelar1.Click += new System.EventHandler(this.btnCancelar1_Click);
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsulta1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsulta1.ForeColor = System.Drawing.Color.White;
            this.btnConsulta1.Location = new System.Drawing.Point(9, 275);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(130, 66);
            this.btnConsulta1.TabIndex = 4;
            this.btnConsulta1.Text = "Consulta";
            this.btnConsulta1.UseVisualStyleBackColor = false;
            this.btnConsulta1.Click += new System.EventHandler(this.btnConsulta1_Click);
            // 
            // btnVacina1
            // 
            this.btnVacina1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVacina1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVacina1.ForeColor = System.Drawing.Color.White;
            this.btnVacina1.Location = new System.Drawing.Point(9, 188);
            this.btnVacina1.Name = "btnVacina1";
            this.btnVacina1.Size = new System.Drawing.Size(130, 66);
            this.btnVacina1.TabIndex = 5;
            this.btnVacina1.Text = "vacinação";
            this.btnVacina1.UseVisualStyleBackColor = false;
            this.btnVacina1.Click += new System.EventHandler(this.btnVacina1_Click);
            // 
            // btnExame1
            // 
            this.btnExame1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExame1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExame1.ForeColor = System.Drawing.Color.White;
            this.btnExame1.Location = new System.Drawing.Point(9, 99);
            this.btnExame1.Name = "btnExame1";
            this.btnExame1.Size = new System.Drawing.Size(130, 66);
            this.btnExame1.TabIndex = 4;
            this.btnExame1.Text = "Exame";
            this.btnExame1.UseVisualStyleBackColor = false;
            this.btnExame1.Click += new System.EventHandler(this.btnExame1_Click);
            // 
            // btnSangue1
            // 
            this.btnSangue1.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSangue1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSangue1.ForeColor = System.Drawing.Color.White;
            this.btnSangue1.Location = new System.Drawing.Point(9, 11);
            this.btnSangue1.Name = "btnSangue1";
            this.btnSangue1.Size = new System.Drawing.Size(130, 66);
            this.btnSangue1.TabIndex = 0;
            this.btnSangue1.Text = "Doar Sangue";
            this.btnSangue1.UseVisualStyleBackColor = false;
            this.btnSangue1.Click += new System.EventHandler(this.btnSangue_Click_1);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.White;
            this.panelFundo.Controls.Add(this.pictureBox1);
            this.panelFundo.Location = new System.Drawing.Point(227, 189);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(827, 523);
            this.panelFundo.TabIndex = 2;
            this.panelFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 402);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 66);
            this.button1.TabIndex = 7;
            this.button1.Text = "Atendente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 817);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelCima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelEsquerdo.ResumeLayout(false);
            this.panelEsquerdo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCima;
        private Label labelCima;
        private Panel panelEsquerdo;
        private Panel panelFundo;
        private Panel panel1;
        private Button btnSangue1;
        private Button btnCancelar1;
        private Button btnConsulta1;
        private Button btnVacina1;
        private Button btnExame1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}