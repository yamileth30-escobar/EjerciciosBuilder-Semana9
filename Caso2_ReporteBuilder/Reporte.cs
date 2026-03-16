using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_ReporteBuilder
{
    public class Reporte
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha { get; set; }
        public string TablaDatos { get; set; }
        public string Graficos { get; set; }
        public string Conclusiones { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("===== REPORTE =====");
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Tabla de Datos: " + TablaDatos);
            Console.WriteLine("Gráficos: " + Graficos);
            Console.WriteLine("Conclusiones: " + Conclusiones);
        }
    }
}
