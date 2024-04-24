using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Commun.Models
{
    public class Pessoa
    {
         Digitando o atalho "prop", cria o atributo instantaneamente.
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome},\n e tenho {Idade} anos.");
        }  
    }
}