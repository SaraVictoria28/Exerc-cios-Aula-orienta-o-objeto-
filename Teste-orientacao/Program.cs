// See https://aka.ms/new-console-template for more information

using System;
using Teste_orientacao;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor { Nome = "Thiago", Diciplina = "Programação" };

            var aluno1 = new Aluno { Nome = "Sara" };
            var aluno2 = new Aluno { Nome = "Gabi" };
            var aluno3 = new Aluno { Nome = "Nathy" };

            List<Aluno> alunos = new List<Aluno>();

            alunos.Add(aluno1);
            alunos.Add(aluno2);
            alunos.Add(aluno3);

            var turma = new Turma
            {
                Nome = "Técnico em Desenvolvimento de Sistemas",
                Professor = professor,
            };

            turma.Alunos = alunos;

            turma.MostrarTurma();

            aluno1.Estudar();
            aluno2.Estudar();
            aluno3.Estudar();

            professor.Ensinar();
        }
    }
}
