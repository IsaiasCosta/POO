using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe03
{
    class Pessoa
    {
        //Atributos
        private string? _nome{get; set;}
      
        private int _idade {get; set;}
        
        private string? _cidade { get; set;}

        //Construtor

        public Pessoa(string nome, int idade, string cidade) 
        {
            _nome = nome;
            _idade = idade;
            _cidade = cidade;

            Mensagem();
        }

        //Metodo 

        private void Mensagem() 
        {
            Console.WriteLine( $" A pesssao de nome {_nome} com idade de {_idade} mora na cidade de {_cidade}");
        }

    }
}
