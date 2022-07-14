using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = (Console.ReadLine());

            Console.WriteLine("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a sua altura: ");
            float altura = (float) Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Seu peso é: " + peso);
            Console.WriteLine($"Sua altura é: {altura}");

            float result = peso / (altura * altura);

            if (result < 18)
            {
                Console.WriteLine("Magreza");
            }
            else if (result >= 18 && result < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (result >= 30 && result < 40)
            {
                Console.WriteLine("Obesidade");
            }
            else 
            {
                Console.WriteLine("Obesidade grave");
            }

        }
    }
}
