using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioFacturacion.Model;
using Microsoft.Data.SqlClient;

namespace InventarioFacturacion.Controller
{
    internal class PersonaController
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        public void CrearEmpleados(int Cedula, string Nombre, string Apellido,
        string Telefono, string correo, string direccion, string Ciudad, int idCargo)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return;
            }
            try
            {
                string queryPersona = "INSERT INTO persona " +
                  "(CC, Nombre, Apellido, Telefono, Correo, Dirección, Ciudad, id_cargo) " +
                  "VALUES (@CC, @NOMBRE, @APELLIDO, @TELEFONO, " +
                  "@CORREO, @DIRECCION, @CIUDAD, @ID_CARGO)";

                using (SqlCommand cmdPerson = new SqlCommand(queryPersona, con))
                {
                    cmdPerson.Parameters.AddWithValue("@CC",Cedula);
                    cmdPerson.Parameters.AddWithValue("@NOMBRE", Nombre);
                    cmdPerson.Parameters.AddWithValue("@APELLIDO", Apellido);
                    cmdPerson.Parameters.AddWithValue("@TELEFONO", Telefono);
                    cmdPerson.Parameters.AddWithValue("@CORREO",correo);
                    cmdPerson.Parameters.AddWithValue("@DIRECCION", direccion);
                    cmdPerson.Parameters.AddWithValue("@CIUDAD", Ciudad);
                    cmdPerson.Parameters.AddWithValue("@ID_CARGO", idCargo);

                    int filasAfectadas = cmdPerson.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Persona creada con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear la persona");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear Persona" + ex.Message);
            }
            conexionBD.CerrarConexion();
        }
        public bool EditarEmpleados(int idPersona, int Cedula, string Nombre, string Apellido,
        string Telefono, string correo, string direccion, string Ciudad, int idCargo)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la cadena de conexion");
                return false;
            }
            try
            {
                string query = @"UPDATE persona SET 
                        CC = @CC,
                        Nombre = @NOMBRE,
                        Apellido = @APELLIDO,
                        Telefono = @TELEFONO,
                        Correo = @CORREO,
                        Dirección = @DIRECCION,
                        Ciudad = @CIUDAD,
                        id_cargo = @ID_CARGO
                        WHERE IDPERSONA = @ID";

                using (SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@ID", idPersona);
                    cmd.Parameters.AddWithValue("@CC", Cedula);
                    cmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                    cmd.Parameters.AddWithValue("@APELLIDO", Apellido);
                    cmd.Parameters.AddWithValue("@TELEFONO", Telefono);
                    cmd.Parameters.AddWithValue("@CORREO", correo);
                    cmd.Parameters.AddWithValue("@DIRECCION", direccion);
                    cmd.Parameters.AddWithValue("@CIUDAD", Ciudad);
                    cmd.Parameters.AddWithValue("@ID_CARGO", idCargo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar{ex.Message}");
                return false;
            }
            finally
            {
              conexionBD.CerrarConexion();   
            }
        }
        public void EliminarEmpleados(int idPersona)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return;
            }
            try
            {
                string query = "DELETE FROM persona WHERE IDPERSONA=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", idPersona);

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas >= 1)
                {
                    MessageBox.Show($"{filasAfectadas} fueron afectadas");
                }
                else
                {
                    MessageBox.Show("Ninguna fila fue afectada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
        }
        public List<Persona> ObtenerEmpleados()
        {
            List<Persona> personas = new List<Persona>();
            SqlConnection con = conexionBD.AbrirConexion();

            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
            }
            try
            {
                string query = ("SELECT * FROM  persona");
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    personas.Add(new Persona
                    {
                        Id = (int)dataReader["IDPERSONA"],
                        Cedula = (int)dataReader["CC"],
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido = dataReader["Apellido"].ToString(),
                        Telefono = dataReader["Telefono"].ToString(),
                        Correo = dataReader["Correo"].ToString(),
                        Direccion = dataReader["Dirección"].ToString(),
                        Ciudad = dataReader["Ciudad"].ToString(),
                        IdCargo = (int)dataReader["id_cargo"]
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return personas; 
        }
    }
}
