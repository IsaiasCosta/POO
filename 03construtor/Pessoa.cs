using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03construtor
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        //3 formar de crir um construtor
        //1º forma

        public Pessoa() { Console.WriteLine($"Construtor vazio"); }

        //2º forma
        public Pessoa(string nome)
        {
            Console.WriteLine($"Contrutor com nome {nome}");
        }

        //3º forma
        public Pessoa(string nome, int idade)
        {
            Console.WriteLine($"Contrutor com nome {nome} e idade {idade}");
        }
    }
}