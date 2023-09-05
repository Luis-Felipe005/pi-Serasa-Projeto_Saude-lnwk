namespace pi_Serasa_Projeto_Saude_lnwk
{
    partial class RecepcaoAtendente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcaoAtendente));
            lblAtendente = new Label();
            btnAceitar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            listView1 = new ListView();
            panel2 = new Panel();
            btnRecusar = new Button();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAtendente
            // 
            lblAtendente.AutoSize = true;
            lblAtendente.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtendente.ForeColor = SystemColors.ControlLightLight;
            lblAtendente.Location = new Point(209, 0);
            lblAtendente.Name = "lblAtendente";
            lblAtendente.Size = new Size(360, 37);
            lblAtendente.TabIndex = 0;
            lblAtendente.Text = "RECEPÇÃO DO ATENDENTE";
            // 
            // btnAceitar
            // 
            btnAceitar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceitar.Location = new Point(276, 0);
            btnAceitar.Name = "btnAceitar";
            btnAceitar.Size = new Size(121, 66);
            btnAceitar.TabIndex = 1;
            btnAceitar.Text = "ACEITAR";
            btnAceitar.UseVisualStyleBackColor = true;
            btnAceitar.Click += btnAceitar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(509, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(12, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 247);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 15);
            label2.Name = "label2";
            label2.Size = new Size(234, 25);
            label2.TabIndex = 8;
            label2.Text = "Informações Do Paciente";
            // 
            // listView1
            // 
            listView1.Location = new Point(0, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(296, 183);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(btnRecusar);
            panel2.Controls.Add(btnAceitar);
            panel2.Location = new Point(0, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 55);
            panel2.TabIndex = 4;
            // 
            // btnRecusar
            // 
            btnRecusar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecusar.Location = new Point(417, 0);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(121, 66);
            btnRecusar.TabIndex = 6;
            btnRecusar.Text = "RECUSAR";
            btnRecusar.UseVisualStyleBackColor = true;
            btnRecusar.Click += btnRecusar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(lblAtendente);
            panel3.Location = new Point(0, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(824, 40);
            panel3.TabIndex = 5;
            // 
            // RecepcaoAtendente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(837, 394);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "RecepcaoAtendente";
            Text = "RecepcaoAtendente";
            Load += RecepcaoAtendente_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblAtendente;
        private Button btnAceitar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListView listView1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button btnRecusar;
    }
}