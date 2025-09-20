using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioFacturacion.Controller;


namespace InventarioFacturacion.vista
{
    public partial class CategoriaVista : Form
    {
        CategoriaController controller = new CategoriaController();
        public CategoriaVista()
        {
            InitializeComponent();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            controller.CrearCategoria(nombre);
            textBox2.Clear();
        }
        private void btnEliminar(object sender, EventArgs e)
        {
            string nombre = textBox2.Text;
            controller.EliminarCategoria(nombre);
            textBox2.Clear();
        }

      
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
