using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe08
{
    public class Colaborador : IBonus, IDesconto
    {
        double faltas;
        public void PremioFaltas()
        {
            System.Console.WriteLine("Informe se o colaborator teve faltas");
            if (faltas == 0)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    double faltas = double.Parse(input);
                    Console.WriteLine($"O colaborador teve {faltas} faltas receber o  Integral");
                }
            }
            else
            {
                Console.WriteLine($"O colaborador teve {faltas} faltas e não ira receber o premio");

            }

        }

        double salarioBruto;
        public void Valetransporte()
        {
            System.Console.WriteLine("Informeo salario do colaboradorclear");
            salarioBruto = double.Parse(Console.ReadLine());
            double desconto = salarioBruto * 0.06;
            Console.WriteLine($"O Salario do colaboras é R${salarioBruto} o desconto do vale transporte  é R${desconto} e ira receber R${salarioBruto - desconto}");

        }
    }
}