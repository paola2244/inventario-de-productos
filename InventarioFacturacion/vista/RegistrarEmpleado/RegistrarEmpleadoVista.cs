using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioFacturacion.Controller;
using InventarioFacturacion.Model;

namespace InventarioFacturacion.vista
{
    public partial class RegistrarEmpleadoVista : Form
    {
        private int idEmpleadoEditando = 0;
        private bool modoEdicion = false;
        private int idEmpleadoEliminando = 0;
        public RegistrarEmpleadoVista()
        {
            InitializeComponent();
            CargarCargos();
            CargarListaEmpleados();

            dataGriedViewEmpleados.CellDoubleClick += DataGridViewEmpleados_CellDoubleClick;
            dataGriedViewEmpleados.CellMouseClick += DataGridViewEmpleados_MouseClick;
        }
        private void CargarCargos()
        {
            try
            {
                CargoController cargoController = new CargoController();
                List<Cargo> cargos = cargoController.ObtenerCargos();

                if (cargos != null && cargos.Count > 0)
                {
                    if (cmbCargo != null)
                    {
                        cmbCargo.DataSource = cargos;
                        cmbCargo.DisplayMember = "NombreCargo";
                        cmbCargo.ValueMember = "IdCargo";
                    }
                    else
                    {
                        MessageBox.Show("Error: Combobox cmbCargo no está inicializado");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron cargos disponibles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cargos" + ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Cedulatxt.Text) ||
                    string.IsNullOrWhiteSpace(Nombretxt.Text) ||
                    string.IsNullOrWhiteSpace(Apellidotxt.Text) ||
                    cmbCargo.SelectedValue == null)
                {
                    MessageBox.Show("Por favor rellena todos los campos");
                    return;
                }
                PersonaController personaController = new PersonaController();

                int Cedula = int.Parse(Cedulatxt.Text);
                string Nombre = Nombretxt.Text.Trim();
                string Apellido = Apellidotxt.Text.Trim();
                string Telefono = telefonotxt.Text.Trim();
                string Correo = Correotxt.Text.Trim();
                string Direccion = Direcciontxt.Text.Trim();
                string Ciudad = Ciudadtxt.Text.Trim();
                int idCargo = (int)cmbCargo.SelectedValue;

                if (modoEdicion)
                {
                    bool actualizado = personaController.EditarEmpleados(idEmpleadoEditando, Cedula, Nombre, Apellido, Telefono, Correo, Direccion, Ciudad, idCargo);

                    if (actualizado)
                    {
                        MessageBox.Show("Empleado actualizado exitosamente");

                        modoEdicion = false;
                        idEmpleadoEditando = 0;
                        btnGuardar.Text = "Guardar";
                    }
                }
                else
                {
                    personaController.CrearEmpleados(Cedula, Nombre, Apellido, Telefono, Correo, Direccion, Ciudad, idCargo);
                }
                CargarListaEmpleados();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void LimpiarFormulario()
        {
            Cedulatxt.Clear();
            Nombretxt.Clear();
            Apellidotxt.Clear();
            telefonotxt.Clear();
            Correotxt.Clear();
            Direcciontxt.Clear();
            Ciudadtxt.Clear();
        }
        private void CargarListaEmpleados()
        {
            try
            {
                PersonaController personaController = new PersonaController();
                List<Persona> empleados = personaController.ObtenerEmpleados();

                dataGriedViewEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los empleados {ex.Message}");
            }
        }
        private void DataGridViewEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGriedViewEmpleados.CurrentRow != null && dataGriedViewEmpleados.CurrentRow.Index >= 0)
                {
                    DataGridViewRow fila = dataGriedViewEmpleados.CurrentRow;

                    if (fila.Cells["Id"].Value != null)
                    {
                        idEmpleadoEditando = Convert.ToInt32(fila.Cells["Id"].Value);

                        Cedulatxt.Text = fila.Cells["Cedula"].Value.ToString();
                        Nombretxt.Text = fila.Cells["Nombre"].Value.ToString();
                        Apellidotxt.Text = fila.Cells["Apellido"].Value.ToString();
                        telefonotxt.Text = fila.Cells["Telefono"].Value.ToString();
                        Correotxt.Text = fila.Cells["Correo"].Value.ToString();
                        Direcciontxt.Text = fila.Cells["Direccion"].Value.ToString();
                        Ciudadtxt.Text = fila.Cells["Ciudad"].Value.ToString();
                        cmbCargo.SelectedValue = Convert.ToInt32(fila.Cells["IdCargo"].Value);

                        modoEdicion = true;
                        btnGuardar.Text = "Actualizar";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void DataGridViewEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {         
                var hitTest = dataGriedViewEmpleados.HitTest(e.X, e.Y);
                if (dataGriedViewEmpleados.CurrentRow != null && dataGriedViewEmpleados.CurrentRow.Index >= 0)
                {
                    DataGridViewRow fila = dataGriedViewEmpleados.CurrentRow;

                    if (fila.Cells["ID"].Value != null)
                    {
                        idEmpleadoEliminando = Convert.ToInt32(fila.Cells["Id"].Value);
                        Cedulatxt.Text = fila.Cells["Cedula"].Value.ToString();
                        Nombretxt.Text = fila.Cells["Nombre"].Value.ToString();
                        Apellidotxt.Text = fila.Cells["Apellido"].Value.ToString();
                        telefonotxt.Text = fila.Cells["Telefono"].Value.ToString();
                        Correotxt.Text = fila.Cells["Correo"].Value.ToString();
                        Direcciontxt.Text = fila.Cells["Direccion"].Value.ToString();
                        Ciudadtxt.Text = fila.Cells["Ciudad"].Value.ToString();
                        cmbCargo.SelectedValue = Convert.ToInt32(fila.Cells["IdCargo"].Value);

                        MessageBox.Show($"Empleado selccionado para eliminar: {Nombretxt.Text}");
                    }
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoEliminando > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    $"¿Eliminar a {Nombretxt.Text} {Apellidotxt.Text}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (resultado == DialogResult.Yes)
                {
                    PersonaController personaController = new PersonaController();
                    personaController.EliminarEmpleados(idEmpleadoEliminando);
                    CargarListaEmpleados();
                    LimpiarFormulario();
                    idEmpleadoEliminando = 0;                  
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado haciendo click derecho en una fila");
            }
        }
    }
}
