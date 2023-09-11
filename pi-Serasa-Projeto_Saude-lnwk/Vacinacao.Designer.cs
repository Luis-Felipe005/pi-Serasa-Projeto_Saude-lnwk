using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    partial class Vacinacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vacinacao));
            panel1 = new Panel();
            lblVacinacao = new Label();
            pictureBox1 = new PictureBox();
            btnTomarVacina = new Button();
            btnCancelar = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(130, 196, 38);
            panel1.Controls.Add(lblVacinacao);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // lblVacinacao
            // 
            lblVacinacao.AutoSize = true;
            lblVacinacao.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblVacinacao.Location = new Point(332, 26);
            lblVacinacao.Name = "lblVacinacao";
            lblVacinacao.Size = new Size(252, 65);
            lblVacinacao.TabIndex = 0;
            lblVacinacao.Text = "Vacinação";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 356);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnTomarVacina
            // 
            btnTomarVacina.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnTomarVacina.Location = new Point(3, 3);
            btnTomarVacina.Name = "btnTomarVacina";
            btnTomarVacina.Size = new Size(270, 61);
            btnTomarVacina.TabIndex = 2;
            btnTomarVacina.Text = "Tomar Vacina";
            btnTomarVacina.UseVisualStyleBackColor = true;
            btnTomarVacina.Click += btnTomarVacina_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(55, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 46);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(600, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 154);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnTomarVacina);
            panel2.Controls.Add(btnCancelar);
            panel2.Location = new Point(316, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 193);
            panel2.TabIndex = 5;
            // 
            // Vacinacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Vacinacao";
            Text = "Form2";
            Load += Vacinacao_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblVacinacao;
        private PictureBox pictureBox1;
        private Button btnTomarVacina;
        private Button btnCancelar;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}