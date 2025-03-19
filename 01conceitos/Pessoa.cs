using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01conceitos
{
    public class Pessoa
    {
        //Atributos
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //Metodos

        public void Apresentacao()
        {
            Console.WriteLine($"Eu sou {Nome}");
        }
        public string MinhaIdade()
        {
            return Idade > 18 ? "Maior de idade" : "Menor de idade";
        }
    }
}