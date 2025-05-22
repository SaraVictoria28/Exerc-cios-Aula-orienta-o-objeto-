using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revisão
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set; }

        public Aluno(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public void Apresentacao ()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade}");
        }

    }
}