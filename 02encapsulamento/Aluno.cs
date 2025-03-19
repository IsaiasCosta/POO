using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02encapsulamento
{
    public class Aluno
    {
        //Atributos duas maneiras de declarar atributos get e set
        //1º
        private string? _nome;
        public string? Nome
         {
            get{return _nome;}
            set{_nome = value;} 
         }
         //2º maneira de declarar atributos get e set
        public double Media { get; set; }
    }

    // Metodos Get: responsavel por extrair valores de atributo privadso
    // Metodos Set: responsavel por atribuir valores aa atributos privados

    /*Construtor: é um metodo especial que é chamado quando um objeto é instanciado
      Sobrecarga: caracteristica interresante, em uma classe podemos ter mais de um construtor*/


}