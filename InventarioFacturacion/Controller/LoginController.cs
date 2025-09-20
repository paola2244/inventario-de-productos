using InventarioFacturacion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventarioFacturacion.Controller
{

    public class LoginController
    {
   
            // Creamos una instancia de tu modelo Credencial
            private readonly Credencial credencial = new Credencial();

        /// <summary>
        /// Valida si el usuario y contraseña existen en la base de datos.
        /// </summary>
        /// <param name="usuario">Nombre del usuario</param>
        /// <param name="contrasena">Contraseña</param>
        /// <returns>true si existe, false si no existe</returns>
        public UsuarioDatos Login(string usuario, string contrasena)
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                return new UsuarioDatos { Existe = false };
            }
            // regla de ejemplo: mínimo 3 caracteres (ajusta según necesites)
            if (usuario.Length < 3 || contrasena.Length < 3)
            {
                return new UsuarioDatos { Existe = false };
            }

            // Llamada al modelo
            return credencial.ObtenerDatosUsuario(usuario, contrasena);

            // Llamamos al modelo
            UsuarioDatos datos = credencial.ObtenerDatosUsuario(usuario, contrasena);
            return datos;
        }
    }
    
}
