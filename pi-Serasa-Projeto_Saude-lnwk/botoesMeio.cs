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
    public partial class botoesMeio : Form
    {
        public botoesMeio()
        {
            InitializeComponent();
        }

        private void btnSangue_Click(object sender, EventArgs e)
        {
          
        }

        private void botoesMeio_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBox1.Location = new Point(ClientSize.Width - pictureBox1.Size.Width  + 150, ClientSize.Height  - pictureBox1.Size.Height+ 50);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
