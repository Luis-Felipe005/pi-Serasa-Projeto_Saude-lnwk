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
            button3 = new Button();
            lblOpcoes = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            painelMeio = new Panel();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            painelMeio.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(213, 10);
            button3.Name = "button3";
            button3.Size = new Size(178, 39);
            button3.TabIndex = 2;
            button3.Text = "Vacinações";
            button3.UseVisualStyleBackColor = true;
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
            painelMeio.Controls.Add(button5);
            painelMeio.Controls.Add(button4);
            painelMeio.Controls.Add(button2);
            painelMeio.Controls.Add(button1);
            painelMeio.Controls.Add(button3);
            painelMeio.Location = new Point(188, 96);
            painelMeio.Name = "painelMeio";
            painelMeio.Size = new Size(400, 265);
            painelMeio.TabIndex = 8;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(114, 223);
            button5.Name = "button5";
            button5.Size = new Size(178, 39);
            button5.TabIndex = 6;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(213, 157);
            button4.Name = "button4";
            button4.Size = new Size(178, 39);
            button4.TabIndex = 5;
            button4.Text = "Consultas";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(14, 157);
            button2.Name = "button2";
            button2.Size = new Size(178, 39);
            button2.TabIndex = 4;
            button2.Text = "Coleta De Exame";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(14, 10);
            button1.Name = "button1";
            button1.Size = new Size(178, 39);
            button1.TabIndex = 3;
            button1.Text = "Doação De Sangue";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(painelMeio);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            painelMeio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Label lblOpcoes;
        private Panel panel1;
        private Panel panel2;
        private Panel painelMeio;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}