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
    public partial class CobrarVista : Form
    {
        public CobrarVista()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as PrincipalVista;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new VentasVista());
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            var frmPrincipal = Application.OpenForms["Principal"] as PrincipalVista;
            if (frmPrincipal != null)
            {
                frmPrincipal.AbrirFormularioEnPanel(new DetalleFacturaVista());
                this.Close(); // cierra el form Ventas que estaba abierto en el panel
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
