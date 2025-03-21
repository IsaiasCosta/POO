using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe04
{
    public class Media
    {
        
        public Media( double nota1, double nota2)
        {
            double resultadoMedia= (nota1+nota2)/2;

          Console.WriteLine($"Media:{resultadoMedia}");
        }
        public Media( double nota1, double nota2, double nota3)
        {
             double resultadoMedia= (nota1+nota2+nota3)/3;
          Console.WriteLine($"Media:{resultadoMedia}");
        }
    }
}