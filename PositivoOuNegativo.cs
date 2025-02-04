using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 0) {
            Console.WriteLine("O número é positvo");
            } 
            else if (x < 0) {
            Console.WriteLine("O número é negativo");    
            } 

            Console.ReadKey(true);
        }
    }

