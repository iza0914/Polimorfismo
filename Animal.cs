using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal está emitindo um som.");
        }
    }
}
