namespace pi_Serasa_Projeto_Saude_lnwk
{
    partial class HealtHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HealtHub));
            panel1 = new Panel();
            lblBemvindo = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            painelMeio = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            painelMeio.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(139, 172, 255);
            panel1.Controls.Add(lblBemvindo);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 134);
            panel1.TabIndex = 0;
            // 
            // lblBemvindo
            // 
            lblBemvindo.AutoSize = true;
            lblBemvindo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBemvindo.Location = new Point(203, 44);
            lblBemvindo.Name = "lblBemvindo";
            lblBemvindo.Size = new Size(353, 40);
            lblBemvindo.TabIndex = 0;
            lblBemvindo.Text = "Bem-Vindo ao HealtHub";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(166, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 33);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 101);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(166, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 33);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(219, 165);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 6;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // painelMeio
            // 
            painelMeio.Controls.Add(pictureBox2);
            painelMeio.Controls.Add(textBox1);
            painelMeio.Controls.Add(button1);
            painelMeio.Controls.Add(pictureBox1);
            painelMeio.Controls.Add(label3);
            painelMeio.Controls.Add(textBox2);
            painelMeio.Controls.Add(label2);
            painelMeio.Location = new Point(125, 160);
            painelMeio.Name = "painelMeio";
            painelMeio.Size = new Size(445, 223);
            painelMeio.TabIndex = 9;
            // 
            // HealtHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(painelMeio);
            Controls.Add(panel1);
            Name = "HealtHub";
            Text = "HealtHub";
            Load += HealtHub_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            painelMeio.ResumeLayout(false);
            painelMeio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblBemvindo;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel painelMeio;
    }
}