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
    public partial class CredencialVista : Form
    {
        public CredencialVista()
        {
            InitializeComponent();
        }
        LoginController loginController = new LoginController();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PanelHijo0.Left = (PanelPadre0.ClientSize.Width - PanelHijo0.Width) / 2;
            PanelHijo0.Top = (PanelPadre0.ClientSize.Height - PanelHijo0.Height) / 2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ImagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void PanelPadre2_Paint(object sender, PaintEventArgs e)
        {
            PanelHijo.Left = (PanelPadre2.ClientSize.Width - PanelHijo.Width) / 2;
            PanelHijo.Top = (PanelPadre2.ClientSize.Height - PanelHijo.Height) / 2;
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario =  Usuario.Text.Trim();
            string contrasena = Contraseña.Text.Trim();

            var controller = new LoginController();
            var datosUsuario = controller.Login(usuario, contrasena);

            if (datosUsuario.Existe)
            {
                // Aquí ya tienes el idcargo del usuario logueado
                if (datosUsuario.IdCargo == 1)
                {
                    // Abrir Form de Administrador
                    new PrincipalAdministrador().Show();
                }
                else if (datosUsuario.IdCargo == 2)
                {
                    // Abrir Form de Vendedor
                    new PrincipalVista().Show();
                }
                else
                {
                    // abrir form de bodeguero
                    new PrincipalBodegueroVista().Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
