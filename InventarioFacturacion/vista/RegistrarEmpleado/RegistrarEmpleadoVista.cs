using System;
using System.Collections.Generic;
using System.Drawing;
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
        private bool modoEliminacion = false;
        public RegistrarEmpleadoVista()
        {
            InitializeComponent();
            CargarCargos();
            CargarListaEmpleados();

            dataGriedViewEmpleados.CellDoubleClick += DataGridViewEmpleados_CellDoubleClick;
            dataGriedViewEmpleados.MouseClick += DataGridViewEmpleados_MouseClick;
        }
        private void CargarCargos()
        {
            try
            {
                CargoController cargoController = new CargoController();
                List<Cargo> cargos = cargoController.ObtenerCargos();

                if (cargos?.Count > 0 && cmbCargo != null)
                {
                    cmbCargo.DataSource = cargos;
                    cmbCargo.DisplayMember = "NombreCargo";
                    cmbCargo.ValueMember = "IdCargo";
                }
                else
                {
                    MessageBox.Show("No se encontraron cargos disponibles");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar cargos: {ex.Message}");
            }
        }
        private void CargarListaEmpleados()
        {
            try
            {
                PersonaController personaController = new PersonaController();
                dataGriedViewEmpleados.DataSource = null;
                dataGriedViewEmpleados.DataSource = personaController.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar empleados: {ex.Message}");
            }
        }
        private void LlenarCamposDesdeRow(DataGridViewRow fila)
        {
            Cedulatxt.Text = fila.Cells["Cedula"].Value.ToString();
            Nombretxt.Text = fila.Cells["Nombre"].Value.ToString();
            Apellidotxt.Text = fila.Cells["Apellido"].Value.ToString();
            telefonotxt.Text = fila.Cells["Telefono"].Value.ToString();
            Correotxt.Text = fila.Cells["Correo"].Value.ToString();
            Direcciontxt.Text = fila.Cells["Direccion"].Value.ToString();
            Ciudadtxt.Text = fila.Cells["Ciudad"].Value.ToString();
            cmbCargo.SelectedValue = Convert.ToInt32(fila.Cells["IdCargo"].Value);
        }
        private void DataGridViewEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGriedViewEmpleados.CurrentRow?.Index >= 0)
                {
                    DataGridViewRow fila = dataGriedViewEmpleados.CurrentRow;

                    if (fila.Cells["Id"].Value != null)
                    {
                        idEmpleadoEditando = Convert.ToInt32(fila.Cells["Id"].Value);
                        LlenarCamposDesdeRow(fila);

                        modoEdicion = true;
                        btnGuardar.Text = "Actualizar";
                        HabilitarCampos();
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
                try
                {
                    if (dataGriedViewEmpleados.CurrentRow?.Index >= 0)
                    {
                        DataGridViewRow fila = dataGriedViewEmpleados.CurrentRow;

                        if (fila.Cells["Id"].Value != null)
                        {
                            idEmpleadoEliminando = Convert.ToInt32(fila.Cells["Id"].Value);
                            LlenarCamposDesdeRow(fila);

                            modoEliminacion = true;
                            DesabilitarCampos();
                            MessageBox.Show($"Empleado seleccionado para eliminar: {Nombretxt.Text}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modoEliminacion)
            {
                MessageBox.Show("No puedes guardar en modo eliminación. Usa el botón ELIMINAR.");
                return;
            }
            if (!ValidarCampos()) return;

            try
            {
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
                    bool actualizado = personaController.EditarEmpleados(idEmpleadoEditando, 
                    Cedula, Nombre, Apellido, Telefono, Correo, Direccion, Ciudad, idCargo);

                    if (actualizado)
                    {
                        MessageBox.Show("Empleado actualizado exitosamente");
                        DesactivarModoEdicion();
                    }
                }
                else
                {
                    personaController.CrearEmpleados(Cedula, Nombre, Apellido, Telefono, 
                    Correo, Direccion, Ciudad, idCargo);
                }
                CargarListaEmpleados();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoEliminando <= 0)
            {
                MessageBox.Show("Seleccione un empleado haciendo click derecho en una fila");
                return;
            }
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
            }
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(Cedulatxt.Text) ||
                string.IsNullOrWhiteSpace(Nombretxt.Text) ||
                string.IsNullOrWhiteSpace(Apellidotxt.Text) ||
                cmbCargo.SelectedValue == null)
            {
                MessageBox.Show("Por favor rellena todos los campos");
                return false;
            }
            return true;
        }
        private void DesactivarModoEdicion()
        {
            modoEdicion = false;
            idEmpleadoEditando = 0;
            btnGuardar.Text = "Guardar";
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

            modoEdicion = false;
            modoEliminacion = false;
            idEmpleadoEditando = 0;
            idEmpleadoEliminando = 0;
            btnGuardar.Text = "Guardar";
            HabilitarCampos();
        }
        private void HabilitarCampos()
        {
            Cedulatxt.ReadOnly = Nombretxt.ReadOnly = Apellidotxt.ReadOnly =
            telefonotxt.ReadOnly = Correotxt.ReadOnly = Direcciontxt.ReadOnly =
            Ciudadtxt.ReadOnly = false;
            cmbCargo.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            Cedulatxt.ReadOnly = Nombretxt.ReadOnly = Apellidotxt.ReadOnly =
            telefonotxt.ReadOnly = Correotxt.ReadOnly = Direcciontxt.ReadOnly =
            Ciudadtxt.ReadOnly = true;
            cmbCargo.Enabled = false;
        }
    }
}