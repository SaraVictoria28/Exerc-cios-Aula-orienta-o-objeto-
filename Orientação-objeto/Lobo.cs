namespace Orientação_objeto
{
    public class Lobo : Animal
    {
        public Lobo(string nome, int idade)
         : base(nome, idade){ }

        public override void EmitirSom(){
            Console.WriteLine("Curupapo! (som de papaguaio)");
        }
    }
}