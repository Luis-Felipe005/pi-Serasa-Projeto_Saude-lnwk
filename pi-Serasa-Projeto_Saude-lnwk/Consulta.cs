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

        private void Consulta_Load(object sender, EventArgs e)
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
            
            pictureBox2.Location = new Point(ClientSize.Width / 2 - pictureBox2.Size.Width / 5 + 150, ClientSize.Height / 2 - pictureBox2.Size.Height / 1 + 50);


        }
    }
}
