// See https://aka.ms/new-console-template for more information


using System;
using Orientação_objeto;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[]{
                new Lobo("Lobo Cinzento", 5),
                new Tigre("Tigre de Bengala", 4),
                new Papaguaio("Louro José", 2),
            };

            foreach (var animal in animais)
            {
                Console.WriteLine(animal);
                animal.EmitirSom();
                Console.WriteLine();
            }
        }
    }
}
