using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05heranca
{
    public class Colaborador : Pessoa
    {
        //Atributos

        private string? _cargo { get; set; }
        private double _salario { get; set; }

        //construtor

        public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
        {
            _cargo = cargo;
            _salario = salario;
            ApresentarPessoa();
            ApresentaColobolador();
        }

        //metodos

            private void ApresentaColobolador()
        {
            Console.WriteLine($"Meu cargo é {_cargo} e ganho R${_salario}");
        }
    }
}