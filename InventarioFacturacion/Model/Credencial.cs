using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace InventarioFacturacion.Model
{

    public class UsuarioDatos
    {
        public bool Existe { get; set; }
        public string Usuario { get; set; }
        public int IdPersona { get; set; }
        public int IdCargo { get; set; }
    }

    public class Credencial
    {
        private readonly ConexionBD conexionBD = new ConexionBD();


        /// <summary>
        /// Valida el usuario y contraseña y devuelve datos del usuario si existe.
        /// </summary>
        public UsuarioDatos ObtenerDatosUsuario(string usuario, string contrasena)
        {
            UsuarioDatos datos = new UsuarioDatos();

            using (SqlConnection con = conexionBD.AbrirConexion())
            {
                if (con == null)
                    return datos; // Existe = false por defecto

                string query = @"
                    SELECT 
                        c.Usuario,
                        c.ID_Persona,
                        p.id_cargo
                    FROM Credenciales c
                    INNER JOIN persona p ON c.ID_Persona = p.ID_Persona
                    WHERE c.Usuario = @Usuario AND c.Contraseña = @Contrasena";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            datos.Usuario = dr["Usuario"].ToString();
                            datos.IdPersona = Convert.ToInt32(dr["ID_Persona"]);
                            datos.IdCargo = Convert.ToInt32(dr["id_cargo"]);
                            datos.Existe = true;
                        }
                        else
                        {
                            datos.Existe = false;
                        }
                    }
                }
            }

            return datos;
        }
    }
  
    
}

