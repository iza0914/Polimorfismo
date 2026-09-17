using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Polimorfismo
{
    public class Macaco : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Ugh ugh aah aah!");
        }
    }
}
