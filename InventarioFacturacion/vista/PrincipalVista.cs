using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace InventarioFacturacion.vista
{
    public partial class PrincipalVista : Form
    {

        // Referencia al formulario actualmente activo
        private Form formularioActivo = null;
        public PrincipalVista()
        {
            InitializeComponent();


        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VentasVista());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new VentasVista());
        }

        // Método reutilizable para abrir cualquier formulario dentro del PanelContenedor
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new TurnosVista());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Al cargar el formulario principal, mostrar el formulario por defecto
            AbrirFormularioEnPanel(new ReporteVista());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
