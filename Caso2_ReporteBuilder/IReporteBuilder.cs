using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_ReporteBuilder
{
    public interface IReporteBuilder
    {
        void SetTitulo(string titulo);
        void SetAutor(string autor);
        void SetFecha(DateTime fecha);
        void SetTablaDatos(string tabla);
        void SetGraficos(string graficos);
        void SetConclusiones(string conclusiones);

        Reporte GetReporte();
    }
}
