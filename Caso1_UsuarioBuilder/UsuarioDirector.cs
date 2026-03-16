using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1_UsuarioBuilder
{
    // El director controla el proceso de construcción
    public class UsuarioDirector
    {
        public void ConstruirUsuarioBasico(IUsuarioBuilder builder)
        {
            builder.SetNombre("Amilcar Antonio");
            builder.SetCorreo("amilcarantonio9@gmail.com");
            builder.SetRol("Usuario");
            builder.SetTelefono("78964576");
            builder.SetEstadoCuenta(true);
        }
    }
}
