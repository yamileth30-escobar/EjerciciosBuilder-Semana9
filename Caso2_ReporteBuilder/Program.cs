using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_ReporteBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se crea el Builder
            ReporteBuilder builder = new ReporteBuilder();

            // Se crea el Director
            ReporteDirector director = new ReporteDirector();

            // El director construye el reporte
            director.ConstruirReporteBasico(builder);

            // Se obtiene el reporte final
            Reporte reporte = builder.GetReporte();

            // Se muestra el reporte
            reporte.Mostrar();

            Console.ReadKey();
        }
    }
}
