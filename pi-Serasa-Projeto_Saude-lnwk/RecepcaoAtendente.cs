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

        private void RecepcaoAtendente_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(ClientSize.Width, panel1.Height);
            listView1.Items.Add(Program.atendente.nome);
            listView1.Items.Add(Program.atendente.cpf);
            listView1.Items.Add(Program.atendente.idade.ToString());
            listView1.Items.Add(Program.atendente.sexo);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void btnRecusar_Click(object sender, EventArgs e)
        {
         
            HealtHub healtHub= new HealtHub();
            healtHub.Show();

        }

        private void btnAceitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paciente aceito!");
            this.Close();
        }
    }
}
