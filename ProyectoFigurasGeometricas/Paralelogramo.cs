using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFigurasGeometricas
{
    public class Paralelogramo : FiguraGeometrica, Poligono
    {
        private double baseParalelogramo;
        private double altura;

        public Paralelogramo(double baseParalelogramo, double altura) : base("Paralelogramo")
        {
            this.baseParalelogramo = baseParalelogramo;
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
            return baseParalelogramo * altura;
        }

        public override string ToString()
        {
            return $"{Nombre} con área: {CalcularArea()}";
        }
    }
}
