using System.Runtime.CompilerServices;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();


            animais.Add(new Leao());

            animais.Add(new Macaco());

            animais.Add(new Cobra());


            foreach (Animal animal in animais)

            {

                animal.EmitirSom();

            }
        }
    }
}