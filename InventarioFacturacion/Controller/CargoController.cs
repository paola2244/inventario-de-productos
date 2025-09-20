using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioFacturacion.Model;
using Microsoft.Data.SqlClient;
using InventarioFacturacion.vista;

namespace InventarioFacturacion.Controller
{
    public class CargoController
    {
        private readonly ConexionBD conexionBD = new ConexionBD();
        public List<Cargo> ObtenerCargos()
        {

            List<Cargo> cargos = new List<Cargo>();

            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null )
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return cargos;
            }
            try
            {
                string query = "SELECT id_cargo, nombrecargo FROM cargo";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cargos.Add(new Cargo()
                    {
                        IdCargo = (int)reader["id_cargo"],
                        NombreCargo = reader["nombrecargo"].ToString() ?? string.Empty,
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conexionBD.CerrarConexion();
            return cargos;
        }   
        public void EliminarEmpleados()
        {

        }
    }
}
