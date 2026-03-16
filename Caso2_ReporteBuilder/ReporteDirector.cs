using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_ReporteBuilder
{
    public class ReporteDirector
    {
        public void ConstruirReporteBasico(IReporteBuilder builder)
        {
            builder.SetTitulo("Reporte de Producción Ganadera");
            builder.SetAutor("Departamento de Agricultura y Ganadería");
            builder.SetFecha(DateTime.Now);
            builder.SetTablaDatos("Registro mensual de producción de leche, cantidad de ganado y peso promedio.");
            builder.SetGraficos("Gráfico comparativo de producción de leche por mes.");
            builder.SetConclusiones("La producción de leche aumentó un 15% debido a mejoras en la alimentación del ganado.");
        }
    }
}
