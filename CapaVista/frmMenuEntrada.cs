using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMenuEntrada : Form
    {
        public frmMenuEntrada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmADM = new ConsultaCompras();
            frmADM.Show();
            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmMU = new IngresoCompras();
            frmMU.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
