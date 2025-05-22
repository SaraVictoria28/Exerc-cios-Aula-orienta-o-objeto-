namespace Orientação_objeto
{
    public class Tigre : Animal
    {
        public Tigre(string nome, int idade)
         : base(nome, idade){}

        public override void EmitirSom(){
            Console.WriteLine("Curupapo! (som de papaguaio)");
        }
    }
}