using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{

    public partial class ConsultaCompras : Form
    {
        controlador cn = new controlador();
        string emp = "usuarios";
        public ConsultaCompras()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarCompras(emp);
            dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgConsulta.DataSource = dt;

        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
