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
    public partial class Bancosangue : Form
    {

        private Panel panel;
        public Bancosangue()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.BackColor = System.Drawing.Color.Red;
            panel.Dock = DockStyle.Top;
            panel.Height = 100;

            Controls.Add(panel);

            KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                ToggleFullScreenMode();
            }
        }

        private void ToggleFullScreenMode()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                panel.Dock = DockStyle.Top;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                panel.Dock = DockStyle.None;
                panel.Height = 0;
            }
        }
    }





}

