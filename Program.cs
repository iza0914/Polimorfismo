using System.Runtime.CompilerServices;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Geometria geometria = new Geometria();
            double AreaQuadrado = geometria.CalcularArea(6);
            double AreaRetangulo = geometria.CalcularArea(70, 7);
            double AreaCirculo = geometria.CalcularArea(8, true);

            Console.WriteLine($"A área do  quadrado: {AreaQuadrado:F2}");
            Console.WriteLine($"A área do  retângulo: {AreaRetangulo:F2}");
            Console.WriteLine($"A área do  circulo: {AreaCirculo:F2}");
        }
    }
}
