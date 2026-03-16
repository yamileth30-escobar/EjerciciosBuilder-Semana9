using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1_UsuarioBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea el Builder
            UsuarioBuilder builder = new UsuarioBuilder();

            // Se crea el Director que controla la construcción
            UsuarioDirector director = new UsuarioDirector();

            // El director construye el usuario paso a paso
            director.ConstruirUsuarioBasico(builder);

            // Se obtiene el usuario construido
            Usuario usuario = builder.GetUsuario();

            // Se muestra la información del usuario
            usuario.Mostrar();

            Console.ReadKey();
        }
    }
}
