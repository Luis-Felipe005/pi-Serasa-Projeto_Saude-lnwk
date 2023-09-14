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
            this.labelCima = new System.Windows.Forms.Label();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelBTN = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnVacina = new System.Windows.Forms.Button();
            this.btnExame = new System.Windows.Forms.Button();
            this.btnSangue = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCima.SuspendLayout();
            this.panelEsquerdo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBTN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCima
            // 
            this.panelCima.BackColor = System.Drawing.Color.Navy;
            this.panelCima.Controls.Add(this.labelCima);
            this.panelCima.Location = new System.Drawing.Point(0, 1);
            this.panelCima.Name = "panelCima";
            this.panelCima.Size = new System.Drawing.Size(803, 160);
            this.panelCima.TabIndex = 0;
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
            this.panelEsquerdo.Controls.Add(this.panel1);
            this.panelEsquerdo.Controls.Add(this.panelBTN);
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 159);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(202, 360);
            this.panelEsquerdo.TabIndex = 1;
            this.panelEsquerdo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEsquerdo_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancelar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(26, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 341);
            this.panel1.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(12, 269);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 48);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consulta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(9, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 0;
            this.button2.Text = "Vacinação";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnVacina_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(9, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 53);
            this.button3.TabIndex = 0;
            this.button3.Text = "Coletar Exame";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnExame_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(9, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 59);
            this.button4.TabIndex = 0;
            this.button4.Text = "Doar Sangue";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnSangue_Click_1);
            // 
            // panelBTN
            // 
            this.panelBTN.Controls.Add(this.panel2);
            this.panelBTN.Controls.Add(this.btnConsulta);
            this.panelBTN.Controls.Add(this.btnVacina);
            this.panelBTN.Controls.Add(this.btnExame);
            this.panelBTN.Controls.Add(this.btnSangue);
            this.panelBTN.Location = new System.Drawing.Point(29, 19);
            this.panelBTN.Name = "panelBTN";
            this.panelBTN.Size = new System.Drawing.Size(142, 341);
            this.panelBTN.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Location = new System.Drawing.Point(-3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 341);
            this.panel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(9, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 48);
            this.button5.TabIndex = 0;
            this.button5.Text = "Consulta";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(9, 157);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 49);
            this.button6.TabIndex = 0;
            this.button6.Text = "Vacinação";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnVacina_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(9, 86);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 53);
            this.button7.TabIndex = 0;
            this.button7.Text = "Coletar Exame";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnExame_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(9, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 59);
            this.button8.TabIndex = 0;
            this.button8.Text = "Doar Sangue";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnSangue_Click_1);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Location = new System.Drawing.Point(9, 236);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(124, 48);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnVacina
            // 
            this.btnVacina.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVacina.ForeColor = System.Drawing.Color.White;
            this.btnVacina.Location = new System.Drawing.Point(9, 157);
            this.btnVacina.Name = "btnVacina";
            this.btnVacina.Size = new System.Drawing.Size(124, 49);
            this.btnVacina.TabIndex = 0;
            this.btnVacina.Text = "Vacinação";
            this.btnVacina.UseVisualStyleBackColor = false;
            this.btnVacina.Click += new System.EventHandler(this.btnVacina_Click_1);
            // 
            // btnExame
            // 
            this.btnExame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExame.ForeColor = System.Drawing.Color.White;
            this.btnExame.Location = new System.Drawing.Point(9, 86);
            this.btnExame.Name = "btnExame";
            this.btnExame.Size = new System.Drawing.Size(124, 53);
            this.btnExame.TabIndex = 0;
            this.btnExame.Text = "Coletar Exame";
            this.btnExame.UseVisualStyleBackColor = false;
            this.btnExame.Click += new System.EventHandler(this.btnExame_Click);
            // 
            // btnSangue
            // 
            this.btnSangue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSangue.ForeColor = System.Drawing.Color.White;
            this.btnSangue.Location = new System.Drawing.Point(9, 11);
            this.btnSangue.Name = "btnSangue";
            this.btnSangue.Size = new System.Drawing.Size(124, 59);
            this.btnSangue.TabIndex = 0;
            this.btnSangue.Text = "Doar Sangue";
            this.btnSangue.UseVisualStyleBackColor = false;
            this.btnSangue.Click += new System.EventHandler(this.btnSangue_Click_1);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 692);
            this.Controls.Add(this.panelEsquerdo);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCima);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelCima.ResumeLayout(false);
            this.panelCima.PerformLayout();
            this.panelEsquerdo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelBTN.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Panel panelBTN;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button BtnCancelar;
    }
}