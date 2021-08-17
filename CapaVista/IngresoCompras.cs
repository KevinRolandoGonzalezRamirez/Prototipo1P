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
    public partial class IngresoCompras : Form
    {
        controlador nuevoCn = new controlador();
        public IngresoCompras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nombre = textBox2.Text;
            string precio = textBox3.Text;
            /*MessageBox.Show(""+nombre);
            MessageBox.Show(""+password);
            */

            bool resultado = nuevoCn.ingresoCompra(id, nombre,precio);
            if (resultado)
            {
                MessageBox.Show("Ingreso correcto");
            }
            else
            {
                MessageBox.Show("Ingreso fallido");
            }
            
        }
    }
}
