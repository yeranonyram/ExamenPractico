using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigurasGeometricas
{

    public class Triangulo : FiguraGeometrica, Poligono
    {
        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura) : base("Triángulo")
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        // Método del Poligono (interfaz)
        public double Area(double valor1, double valor2)
        {
            // Este método no se usa ya que usamos los valores ya almacenados en la clase
            throw new NotImplementedException("Este método no se usa en esta implementación.");
        }

        public double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public override string ToString()
        {
            return $"{Nombre} con área: {CalcularArea()}";
        }
    }
}
