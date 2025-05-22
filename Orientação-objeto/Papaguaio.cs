namespace Orientação_objeto
{
    public class Papaguaio : Animal
    {
        public Papaguaio(string nome, int idade)
         : base(nome, idade){}

        public override void EmitirSom(){
            Console.WriteLine("Curupapo! (som de papaguaio)");
        }
    }
}