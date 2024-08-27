using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigurasGeometricas
{
    public class Rectangulo : FiguraGeometrica, Poligono
    {
        private double ancho;
        private double alto;

        public Rectangulo(double ancho, double alto) : base("Rectángulo")
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // Método del Poligono (interfaz)
        public double Area(double valor1, double valor2)
        {
            // Este método no se usa ya que usamos los valores ya almacenados en la clase
            throw new NotImplementedException("Este método no se usa en esta implementación.");
        }

        public double CalcularArea()
        {
            return ancho * alto;
        }

        public override string ToString()
        {
            return $"{Nombre} con área: {CalcularArea()}";
        }
    }
}
