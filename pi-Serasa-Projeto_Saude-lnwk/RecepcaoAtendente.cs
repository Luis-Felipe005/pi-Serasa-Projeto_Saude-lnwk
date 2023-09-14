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
            Atendente atendente = new Atendente();

            List<Atendente> atendentes = atendente.buscaTodos();

            foreach (Atendente a in atendentes)
            {
                listView1.Items.Add(a.nome);
                listView1.Items.Add(a.cpf);
                listView1.Items.Add(a.idade.ToString());
                listView1.Items.Add(a.sexo);

            }



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
         


        }
    }
}
