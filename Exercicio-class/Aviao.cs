namespace Exercicio_class
{
    public class Aviao
    {
        public string Modelo {get; set;} 
        public int Velocidade {get; set;}
        public double Altitude {get; set;}
        public string Marca {get; set;}

        public Aviao(string modelo, int velocidade, double altitude, string marca)
        {
            Modelo = modelo;
            Velociadade = velocidade;
            Altitude = altitude;
            Marca = marca;
        }

        public void Apresentação(){
            Console.WriteLine($"O avião do modelo: {Modelo}, da marca: {Marca}, está alcansando um alatitude de {Altitude} pés e em uma velocidade de {Velocidade} km/h.");
        }

        public virtual void Acelerar(){
            Console.WriteLine("Avião acelerando...");
        }

        public void Subir(){
            Console.WriteLine("Avião está decolando...");
        }

        public void Reduzir(){
            Console.WriteLine("Avião está reduzindo...");
        }
        public void Descer(){
            Console.WriteLine("Avião está descedo...");
        }

    }
}