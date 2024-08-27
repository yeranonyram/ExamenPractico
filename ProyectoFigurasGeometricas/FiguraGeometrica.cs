using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigurasGeometricas
{
    public class FiguraGeometrica
    {
        public string Nombre { get; set; }
        public FiguraGeometrica(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
