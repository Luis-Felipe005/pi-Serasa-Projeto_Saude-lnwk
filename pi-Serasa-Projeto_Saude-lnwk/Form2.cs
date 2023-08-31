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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            panel1.Size = new Size(ClientSize.Width, 100);

            panel2.Width = Width;
            panel2.Location = new System.Drawing.Point(0, Height - panel2.Height);

            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);

            lblOpcoes.Location = new Point(ClientSize.Width / 2 - lblOpcoes.Size.Width / 2);

        }
    }
}
