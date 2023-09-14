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


            panelFundo.Size = new Size(ClientSize.Width - 200, ClientSize.Height -200);
            panelFundo.Location = new Point(ClientSize.Width - 1710, ClientSize.Height - 810);


            
            panelCima.Size = new Size(ClientSize.Width, 200);
            panelEsquerdo.Size = new Size(200, ClientSize.Height);

           


            this.Controls.Add(pictureBox1); // Adiciona a PictureBox ao formulário



        }

        public void carregaTela(Form form)
        {
            form.TopLevel = false;
            panelFundo.Controls.Clear();
            panelFundo.Controls.Add(form);
            // form.Location = new Point(panelFundo.Width,panelFundo.Height);
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

        private void BtnVacina_Click(object sender, EventArgs e)
        {
            carregaTela(new Vacinacao());
        }

        private void panelFundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSangue_Click_1(object sender, EventArgs e)
        {
            carregaTela(new Bancosangue());
        }
    }
}
