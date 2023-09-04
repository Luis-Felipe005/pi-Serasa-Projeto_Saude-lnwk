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
    public partial class HealtHub : Form
    {
        public HealtHub()
        {
            InitializeComponent();
        }

        private void HealtHub_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            panel1.Size = new Size(ClientSize.Width, 100);

            lblBemvindo.Location = new Point(ClientSize.Width / 2 - lblBemvindo.Size.Width / 2);

            painelMeio.Location = new Point(ClientSize.Width / 2 - painelMeio.Size.Width / 2, ClientSize.Height / 2 - painelMeio.Size.Height / 2);

        }

        private void HealtHub_Load_1(object sender, EventArgs e)
        {

        }
    }
}
