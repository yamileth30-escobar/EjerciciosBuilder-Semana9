using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2_ReporteBuilder
{
    public class ReporteBuilder : IReporteBuilder
    {
        private Reporte reporte = new Reporte();

        public void SetTitulo(string titulo)
        {
            reporte.Titulo = titulo;
        }

        public void SetAutor(string autor)
        {
            reporte.Autor = autor;
        }

        public void SetFecha(DateTime fecha)
        {
            reporte.Fecha = fecha;
        }

        public void SetTablaDatos(string tabla)
        {
            reporte.TablaDatos = tabla;
        }

        public void SetGraficos(string graficos)
        {
            reporte.Graficos = graficos;
        }

        public void SetConclusiones(string conclusiones)
        {
            reporte.Conclusiones = conclusiones;
        }

        public Reporte GetReporte()
        {
            return reporte;
        }
    }
}
