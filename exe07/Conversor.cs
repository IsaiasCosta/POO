using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe07
{
    class Conversor : Padrao
    {
        public override void DolarReal()
        {
            System.Console.WriteLine("Digite o valor em dolar: ");
            double dolar = double.Parse(Console.ReadLine());
            double real = dolar / 5.67;
            System.Console.WriteLine($"O valor em real é: {real}");        
        }

        public override void RealDolar()
        {
            Console.WriteLine("Digite o valor em real: ");
            double real = double.Parse(Console.ReadLine());
            double dolar = real * 5.67;
           Console.WriteLine($"O valor em Dolar é: {dolar}");     
            
        }
    }
}