using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _04atributosEmetodosStaticos
{
    public class Calculadora
    {
        //Atributo 
        public static int numero = 10;

        //Método
        public static void soma(int num1, int num2)
        {
            System.Console.WriteLine($"Soma dos valores é {num1+num2}");
        }
    }
}