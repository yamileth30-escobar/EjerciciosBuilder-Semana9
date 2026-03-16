using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1_UsuarioBuilder
{
    // Define los pasos para construir el objeto Usuario
    public interface IUsuarioBuilder
    {
        void SetNombre(string nombre);
        void SetCorreo(string correo);
        void SetContrasena(string contrasena);
        void SetRol(string rol);
        void SetTelefono(string telefono);
        void SetDireccion(string direccion);
        void SetEstadoCuenta(bool estado);

        Usuario GetUsuario();
    }
}
