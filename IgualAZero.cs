using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            float x = float.Parse(Console.ReadLine());

            if (x == 0) {
             Console.WriteLine("O número é igual a zero");
            } 
            else {
            Console.WriteLine("Não é zero :D");
            }

            Console.ReadKey(true);
        }
    }
