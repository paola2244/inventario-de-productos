using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioFacturacion.Model;
using Microsoft.Data.SqlClient;

namespace InventarioFacturacion.Controller
{
    public class CajaController
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        public List<Caja> ObtenerCajas()
        {
            List<Caja> cajas = new List<Caja>();
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
            }
            try
            {
                string query = "SELECT * FROM Caja";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        cajas.Add(new Caja
                        {
                            IdCaja = (int)dataReader["IdCaja"],
                            MontonInicial = dataReader["MontoInicial"] != DBNull.Value ? (decimal)dataReader["MontoInicial"] : 0,
                            MontoFinal = dataReader["MontoFinal"] != DBNull.Value ? (decimal)dataReader["MontoFinal"] : 0,
                            TotalVentasEfectivo = dataReader["TotalVentasEfectivo"] != DBNull.Value ? (decimal)dataReader["TotalVentasEfectivo"] : 0,
                            TotalVentasOnline = dataReader["TotalVentasOnline"] != DBNull.Value ? (decimal)dataReader["TotalVentasOnline"] : 0,
                            Total = dataReader["TotalCaja"] != DBNull.Value ? (decimal)dataReader["TotalCaja"] : 0,
                            Diferencia = dataReader["Diferencia"] != DBNull.Value ? (decimal)dataReader["Diferencia"] : 0
                        });
                    }
                    dataReader.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener las cajas :{ex.Message}");
            }
            finally
            {
                conexionBD.CerrarConexion();
            }
            return cajas;
        }
    }
}
