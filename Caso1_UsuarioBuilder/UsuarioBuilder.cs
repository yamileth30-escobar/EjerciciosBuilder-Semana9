using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1_UsuarioBuilder
{
    // Builder que construye el objeto Usuario paso a paso
    public class UsuarioBuilder : IUsuarioBuilder
    {
        private Usuario usuario = new Usuario();

        public void SetNombre(string nombre)
        {
            usuario.Nombre = nombre;
        }

        public void SetCorreo(string correo)
        {
            usuario.Correo = correo;
        }

        public void SetContrasena(string contrasena)
        {
            usuario.Contrasena = contrasena;
        }

        public void SetRol(string rol)
        {
            usuario.Rol = rol;
        }

        public void SetTelefono(string telefono)
        {
            usuario.Telefono = telefono;
        }

        public void SetDireccion(string direccion)
        {
            usuario.Direccion = direccion;
        }

        public void SetEstadoCuenta(bool estado)
        {
            usuario.EstadoCuenta = estado;
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }
    }
}
