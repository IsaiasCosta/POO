using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exe02
{
    public class Aluno
    {
        //atributos
        public string? Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        //Metodos

        private double Media()
        {
           return (Nota1+Nota2)/2;
        }
        private string Situacao()
        {
            return Media() >=70 ?"Aprovado" : "Reprovado";
        }
        public string Mensagem()
        {
           return $" O aluno {Nome} conseguiu a Média de {Media()} com isso ele esta {Situacao()}";
        }

    }
}