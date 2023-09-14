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

          //  carregaTela(new botoesMeio());

            panelFundo.Size = new Size(ClientSize.Width - 130, ClientSize.Height -130);
            panelFundo.Location = new Point(ClientSize.Width - 1728, ClientSize.Height - 858);

            labelCima.Location = new Point(ClientSize.Width - 1150, ClientSize.Height - 990);
           

            panelEsquerdo.Size = new Size(panelEsquerdo.Width, ClientSize.Height);
            panelCima.Size = new Size(ClientSize.Width, panelCima.Height);
         

           


            //this.Controls.Add(pictureBox1); // Adiciona a PictureBox ao formulário



        }

        public void carregaTela(Form form)
        {
            form.TopLevel = false;
            panelFundo.Controls.Clear();
            panelFundo.Controls.Add(form);
           
            form.Size = new Size(panelFundo.Width, panelFundo.Width);
            form.Show();
        }

        private void BtnSangue_Click(object sender, EventArgs e)
        {
            // Sangue doarsangue = new Sangue();
            //panelFundo.Size = new Size(ClientSize.Width, ClientSize.Height);
            //panel.Location = new Point(ClientSize.Width / 2 - panelFundo.Size.Width / 2 + 100, ClientSize.Height / 2 - panelFundo.Size.Height / 2 + 100);
            // doarsangue.TopLevel = false; 
            // panelFundo.Controls.Add(doarsangue);
            //doarsangue.Show();
           


        }

      

        private void panelFundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSangue_Click_1(object sender, EventArgs e)
        {
            panelCima.BackColor = Color.DarkRed;
            panelEsquerdo.BackColor = Color.DarkRed;
            
           // panelCima.Size = new Size(ClientSize.Width, panelCima.Height);
            panelEsquerdo.Size = new Size(panelEsquerdo.Width, ClientSize.Height);
            
            carregaTela(new Bancosangue());
        }

        private void btnExame_Click(object sender, EventArgs e)
        {
            panelCima.BackColor = Color.SteelBlue;
            panelEsquerdo.BackColor=Color.SteelBlue;

            carregaTela(new ColetaExame());
        }

        private void btnVacina_Click_1(object sender, EventArgs e)
        {
            panelCima.BackColor = Color.Green;
            panelEsquerdo.BackColor= Color.Green;

            carregaTela(new Vacinacao());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            panelEsquerdo.BackColor = Color.Gray;
            panelCima.BackColor = Color.Gray;
            carregaTela(new Consulta());
        }

        private void panelEsquerdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            carregaTela(new HealtHub());
            

        }
    }
}
