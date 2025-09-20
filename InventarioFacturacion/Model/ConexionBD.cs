using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace InventarioFacturacion.Model
{
     public class ConexionBD
     {
        private SqlConnection conexion;

        public SqlConnection AbrirConexion()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-H8IVUVU\\SQLEXPRESS;Initial Catalog=INVENTARIO;Integrated Security=True;Encrypt=False");
            try 
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex) 
            {             
                    System.Windows.Forms.MessageBox.Show("Error en la conexion",ex.Message);
                    return null;               
            }
           
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion != null)
            {
                conexion.Close();              
            }
            return null;
        }
     }
}
