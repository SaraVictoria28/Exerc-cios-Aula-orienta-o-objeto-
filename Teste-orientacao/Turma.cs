namespace Teste_orientacao
{
    public class Turma
    {
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public void MostrarTurma()
        {
            Console.WriteLine($"Turma: {Nome}");
            Console.WriteLine($"Turma: {Professor.Nome} - {Professor.Diciplina}");
            Console.WriteLine($"Alunos:");

            foreach (var aluno in Alunos)
            {
                Console.WriteLine($" - {aluno.Nome}");
            }
            Console.WriteLine("");
        }
    }
}
