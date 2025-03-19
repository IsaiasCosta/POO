using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05heranca
{
    public class Pessoa
    {
        //Atributos
        private string? _nome { get; set; }
        private int _idade { get; set; }

        //Construtor
        protected Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        //Metodos co protegidos
        protected void ApresentarPessoa()
        {
           Console.WriteLine($"Olá, eu sou {_nome} e tenho {_idade} anos");
        }
    }
}