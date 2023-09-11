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
    public partial class Vacinacao : Form
    {
        public Vacinacao()
        {
            InitializeComponent();
        }

        private void Vacinacao_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;




            panel1.Location = new Point(0, 0);
            panel1.Size = new Size(ClientSize.Width, 200);

            pictureBox1.Size = new Size(ClientSize.Width, ClientSize.Height);


            panel2.Location = new Point(ClientSize.Width / 2 - panel2.Size.Width / 2, ClientSize.Height / 2 - panel2.Size.Height / 2);


            lblVacinacao.Location = new Point(ClientSize.Width / 2 - panel2.Size.Width / 2);








        }

        private void btnTomarVacina_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Vacina agendada com sucesso!");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            panel2.Visible = false;
            WindowState = FormWindowState.Maximized;
            panel1.Size = new Size(ClientSize.Width, ClientSize.Height); ;
            panel1.Location = new Point(0, 0);
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            panel1.Controls.Add(form2);
            form2.Show();
        }
    }
}
