namespace Teste_orientacao
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public Turma Turma {get; set;}

        public void Estudar()
        {
            Console.WriteLine($"O {Nome} está estudando. \n");
        }
    }
}