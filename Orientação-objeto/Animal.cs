namespace Orientação_objeto
{
    public class Animal
    {
        public string Nome {get; set;}
        public int Idade { get; set; }

        public Animal (string nome, int idade){
            Nome= nome;
            Idade = idade;
        }

        public virtual void EmitirSom(){ // vai poder se rescrever sobre ele.
            Console.WriteLine("O animal emite um som.");
        }

        public override string ToString(){ // herdando o metodo que ele está sob escrevendo;
            return $"Nome: {Nome}, Idade: {Idade} anos.";
        }
    }
}