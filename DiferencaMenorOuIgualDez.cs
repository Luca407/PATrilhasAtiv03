using System;

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int x = Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("Digite um número: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
          int diferenca = x - y; // Calcula a diferença absoluta entre os dois números

            if (diferenca <= 10 && diferenca > 0) {
             Console.WriteLine("A diferença entre os números é menor ou igual a 10.");
            } 
            else {
            Console.WriteLine("A diferença entre os números é maior que 10.");
            }

            Console.ReadKey(true);
        }
    }

