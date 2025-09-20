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
using InventarioFacturacion.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventarioFacturacion.vista
{
    public partial class CajasVistas : Form
    {
        public int CajaSeleccionada=0;
        public string EmpresaSeleccionada="";
        public CajasVistas()
        {
            InitializeComponent();
            CargarEmpresas();
            CargarCajas();
        }

        private void CargarEmpresas()
        {
            try
            {
                List<string> empresas = new List<string>
                {
                    "Empresa Principal",
                    "Papleria",
                    "Sucursal del sur",
                    "Punto de venta"
                };
                cmbEmpresa.DataSource = empresas;
                cmbEmpresa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargas las empresas: {ex.Message}");
            }
        }
        private void CargarCajas()
        {
            try
            {
                CajaController cajaController = new CajaController();
                List<Caja> cajas = cajaController.ObtenerCajas();
                if (cajas?.Count > 0)
                {
                    cmbCajas.DataSource = cajas;
                    cmbCajas.DisplayMember = "NombreCaja";
                    cmbCajas.ValueMember = "IdCaja";
                }
                else
                {
                    MessageBox.Show("No hay cajas disponiblesa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las cajas {ex.Message}");
            }
        }

        private void Botoningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCajas.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una caja");
                    return;
                }
                CajaSeleccionada = (int)cmbCajas.SelectedValue;
                EmpresaSeleccionada = cmbEmpresa.SelectedItem?.ToString() ?? "";

                TurnosVista turnosVista = new TurnosVista(CajaSeleccionada, EmpresaSeleccionada);
                this.Hide();
                turnosVista.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
