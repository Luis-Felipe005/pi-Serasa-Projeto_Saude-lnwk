using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_Serasa_Projeto_Saude_lnwk
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)//Não fununcia
        {
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            panel3.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Consulta_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;


            panel1.Size = new Size(ClientSize.Width, 100);

            label1.Location = new Point(ClientSize.Width / 2 - label1.Size.Width / 2);

            panel2.Size = new Size(ClientSize.Height, 100);

            panel2.Width = Width;
            panel2.Location = new System.Drawing.Point(0, Height - panel2.Height);

            panel3.Location = new Point(ClientSize.Width / 2 - panel3.Size.Width / 2, ClientSize.Height / 2 - panel3.Size.Height / 2);

            int offsetX = 300; // Ajuste este valor conforme necessário
            pictureBox1.Location = new Point(offsetX, ClientSize.Height / 2 - pictureBox1.Size.Height / 1 + 50);

            //int centralizar = 500; // Ajuste este valor conforme necessário
            //pictureBox2.Location = new Point(offsetX, ClientSize.Height /  - pictureBox2.Size.Height / 2 + 400);

            pictureBox2.Location = new Point(ClientSize.Width / 2 - pictureBox2.Size.Width / 5 + 350, ClientSize.Height / 2 - pictureBox2.Size.Height / 1 + 50);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//
        {
            MessageBox.Show("Consulta agendada , aguarde!");
        }
    }
}
