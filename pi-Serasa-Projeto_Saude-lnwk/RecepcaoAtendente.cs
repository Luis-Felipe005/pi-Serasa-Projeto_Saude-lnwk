using MySql.Data.MySqlClient;
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
    public partial class RecepcaoAtendente : Form
    {

        public RecepcaoAtendente()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RecepcaoAtendente_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            panel3.Size = new Size(ClientSize.Width, 150);


            lblAtendente.Location = new Point(ClientSize.Width / 2 - lblAtendente.Size.Width / 2);

            panel2.Size = new Size(ClientSize.Height, 150);

            panel2.Width = Width;
            panel2.Location = new System.Drawing.Point(0, Height - panel2.Height);

            btnAceitar.Location = new Point(ClientSize.Width / 2 - panel2.Size.Height / 1 - panel2.Size.Width / 20);

            btnRecusar.Location = new Point(ClientSize.Width / 2 - panel2.Size.Height / 7 - panel2.Size.Width / 500);

            panel1.Location = new Point(0, 250 - listView1.Width / 250);

            pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Size.Width / 2 + 500, ClientSize.Height / 2 - pictureBox1.Size.Height / 2 + 100);





        }

        private void RecepcaoAtendente_Load_1(object sender, EventArgs e)
        {
            Atendente atendente = new Atendente();

            List<Atendente> atendentes = new List<Atendente>();

            foreach (Atendente a in atendentes)
            {
                listView1.Items.Add(a.nome);
                listView1.Items.Add(a.cpf);
                listView1.Items.Add(a.idade.ToString());
                listView1.Items.Add(a.sexo);
            }

        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {




        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
            HealtHub healtHub = new HealtHub();

            healtHub.Show();
        }
    }
}
