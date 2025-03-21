using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe06
{
    public class Calculadora
    {
       

        //metodo static

        public static void Soma(int num1, int num2)
        {
        Console.WriteLine($" Soma = {num1+num2}");
        }
        public static void Subtracao(int num1, int num2)
        {
         Console.WriteLine($"Subtração = {num1-num2}");
        }
    }
}