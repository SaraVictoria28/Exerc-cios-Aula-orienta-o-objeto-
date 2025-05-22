namespace Teste_orientacao
{
    public class Professor
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Diciplina { get; set; }
        public Turma Turma {get; set;}


        public void Ensinar()
        {
            Console.WriteLine($"O {Nome} está instruindo\n");
        }
    }
}
