using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	int x = Convert.ToInt32(Console.ReadLine());
           	Console.WriteLine("Digite o segundo número: ");
           	int y = Convert.ToInt32(Console.ReadLine());
           	
           	
           	if (x < y) {	
           	Console.WriteLine("O menor número é: " + x);
           	} else {
           	Console.WriteLine("O menor número é: " + y);	
           	}
           	Console.ReadKey(true);
        }
    }
