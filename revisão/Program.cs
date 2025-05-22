// See https://aka.ms/new-console-template for more information


using System;

using revisão;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double [] idades = new double [4];

            // double soma = 0;
            // double media = 0;

            // for(int i = 0; i<idades.Length; i++){
            //     idades[i] = double.Parse(Console.ReadLine());
            //     soma+= idades[i];
            // }
            // media = soma/idades.Length;
            // Console.WriteLine($"O resultados das idades é: {media}");

            // criação de lista

            // List<int> numeros = new List<int>();
            // numeros.Add(30);
            // numeros.Add(15);

            // foreach (var numero in numeros)
            // {
            //     Console.WriteLine(numero);
            // }

            Aluno aluno = new Aluno("Sara", 18);
            aluno.Apresentacao();
        }
    }
}