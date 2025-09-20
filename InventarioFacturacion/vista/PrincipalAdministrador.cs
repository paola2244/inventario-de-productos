using InventarioFacturacion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacturacion.vista
{
    public partial class PrincipalAdministrador : Form
    {


        // Referencia al formulario actualmente activo
        private Form formularioActivo = null;
        public PrincipalAdministrador()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public void AbrirFormularioEnPanel(Form formHijo)
        {
            // Cierra el formulario anterior si existe
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formHijo;

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PanelContenedor.Controls.Clear(); // Limpiar antes de agregar uno nuevo
            PanelContenedor.Controls.Add(formHijo);
            PanelContenedor.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new ReporteVista());
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new TablaInventarioVista());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new RegistrarEmpleadoVista());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new CategoriaVista());
        }

        private void ListadoClientes_Click(object sender, EventArgs e)
        {

            // Al cargar el formulario principal, mostrar el formulario por defecto
           // AbrirFormularioEnPanel(new CategoriaVista());
        }

        private void ReportesTurnos_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new TurnosVista());
        }
    }
}
