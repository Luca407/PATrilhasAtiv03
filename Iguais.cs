using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	int x = Convert.ToInt32(Console.ReadLine());
           	Console.WriteLine("Digite o segundo número: ");
           	int y = Convert.ToInt32(Console.ReadLine());
           	
           	
           	if (x == y) {	
           	Console.WriteLine("Os números são iguais");
           	} else {
           	Console.WriteLine("Os números não são iguais");	
           	}
           	Console.ReadKey(true);
        }
    }
