public class Individuo
{
    public float Peso {get; set;}
    public string Nome {get; set;}
    public float Altura {get; set;}
    public double CalculoIMC {get => Peso / (Altura * Altura);} 

    public Individuo (float peso, string nome, float altura){
        Peso = peso;
        Nome = nome;
        Altura = altura;
    }

    
}