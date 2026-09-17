using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Geometria
    {
        public double CalcularArea(double Lado)
        {
            return Lado * Lado;
        }
        public double CalcularArea(double BaseRetangulo, double AlturaRetangulo)
        {
            return BaseRetangulo * AlturaRetangulo;
        }

        public double CalcularArea(double Raio, bool IsCirculo)
        {
            return Math.PI * Raio * Raio;
        }
    }
}
