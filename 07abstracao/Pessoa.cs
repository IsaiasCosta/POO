using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07abstracao
{
     class Pessoa : Acoes
    {
        public override void Andar()
        {
           System.Console.WriteLine("Andando...");
        }

        public override void Falar()
        {
            System.Console.WriteLine("Falando...");
        }
    }
}