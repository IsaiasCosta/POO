using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07abstracao
{
    abstract class Acoes
    {
        // Métodos obrigatórios

        public abstract void Falar();
        public abstract void Andar();

        //Metodos opcionais
        public void Pular()
        {
          Console.WriteLine("Pulando...");
        }
    }
}