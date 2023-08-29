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
    public partial class ProcessoConcluido : Form
    {
        public ProcessoConcluido()
        {
            InitializeComponent();
        }

        private void ProcessoConcluido_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            ProcessoConcluido processoconcluido = new ProcessoConcluido();

            label1 = new Label();


            label1.AutoSize = true;
            label1.Location = new Point(ClientSize.Width / 2 - label1.Size.Width / 2);


            

            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2);

            pictureBox1.Size = new Size(ClientSize.Width, ClientSize.Height);



        }


    }
}
