using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioFacturacion.Model;
using Microsoft.Data.SqlClient;

namespace InventarioFacturacion.Controller
{
    public class CategoriaController : ConexionBD
    {
        //Se crea un objeto tipo ConexionBD para poder abrir y cerrar la conexion de la bd
        private readonly ConexionBD conexionBD = new ConexionBD();
        public void CrearCategoria(string nombreCategoria)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return;
            }
                try
                {
                    string query = "INSERT INTO TipoCategoria (NombreCategoria) VALUES (@NOMBRECATEGORIA)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", nombreCategoria);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        MessageBox.Show($"{filasAfectadas} filas fueron afectadas");
                    }
                    else
                    {
                        MessageBox.Show("Ninguna fila fue afectada");
                    }
                    conexionBD.CerrarConexion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }          
        }
        public void EliminarCategoria(string nombreCategoria)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return;
            }
            try
            {
                string query = "DELETE FROM TipoCategoria WHERE NombreCategoria = @NOMBRECATEGORIA";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NOMBRECATEGORIA", nombreCategoria);

                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas >= 1)
                {
                    MessageBox.Show($"{filasAfectadas} filas fueron afectadas");
                }
                else
                {
                    MessageBox.Show("Ninguna fila fue afectada");
                }
                conexionBD.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EditarCategoria(string NombreActualCategoria, string NuevoNombreCategoria)
        {
            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");
                return;
            }
            try
            {
                string query = "UPDATE TipoCategoria SET NombreCategoria = @NUEVONOMBRE WHERE NombreCategoria = @NOMBREACTUAL";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NUEVONOMBRE", NuevoNombreCategoria);
                cmd.Parameters.AddWithValue("@NOMBREACTUAL", NombreActualCategoria);
                int filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas >= 1)
                {
                    MessageBox.Show($"{filasAfectadas} filas fueron afectadas");
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
        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();

            SqlConnection con = conexionBD.AbrirConexion();
            if (con == null)
            {
                MessageBox.Show("No se pudo abrir la conexion");

            }
            try
            {
                string query = ("SELECT * FROM TipoCategoria ");
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader DataReader = cmd.ExecuteReader();

                while (DataReader.Read())
                {
                    categorias.Add(new Categoria
                    {
                        Id = (int)DataReader["IdTipoCategoria"],
                        NombreCategoria = DataReader["NombreCategoria"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return categorias;
        }
    }
}
