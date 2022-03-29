using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string nome = Console.ReadLine();

            Console.WriteLine("What's your height? Ex: 1,63");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Whats your weight in Kg? Ex:59,3");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("{0}, your height is {1} and your weight is {2}", nome, altura, peso);
            Console.WriteLine("Your IMC is {0}!!!!", imc);

        }
    }
}