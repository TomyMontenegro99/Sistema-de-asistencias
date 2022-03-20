using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORUS.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBienvenida_Paint(object sender, PaintEventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            PruebaForm frm = new PruebaForm();
            frm.ShowDialog();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PruebasControl Control = new PruebasControl();
            panel2.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panel2.Controls.Add(Control);
        }
    }
}
