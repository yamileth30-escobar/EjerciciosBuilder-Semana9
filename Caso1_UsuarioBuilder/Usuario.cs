using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso1_UsuarioBuilder
{
       // Clase que representa el objeto que se va a construir
        public class Usuario
        {
            public string Nombre { get; set; }
            public string Correo { get; set; }
            public string Contrasena { get; set; }
            public string Rol { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public bool EstadoCuenta { get; set; }

            // Método para mostrar la información
            public void Mostrar()
            {
                Console.WriteLine("===== USUARIO =====");
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("Correo: " + Correo);
                Console.WriteLine("Rol: " + Rol);
                Console.WriteLine("Teléfono: " + Telefono);
                Console.WriteLine("Estado: " + EstadoCuenta);
            }
        }
    }
