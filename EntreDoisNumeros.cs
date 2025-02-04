using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
           	int n1 = Convert.ToInt32(Console.ReadLine());
           	Console.WriteLine("Digite o segundo número: ");
           	int n2 = Convert.ToInt32(Console.ReadLine());
           	Console.WriteLine("Digite o terceiro número: ");
           	int n3 = Convert.ToInt32(Console.ReadLine());
           	
           	
           	if (n1 < n2 && n1 > n3) {	
           	Console.WriteLine("O número " + n1 + " é menor que o numero " + n2 + " e maior que o " + n3);
           	} else {
           	Console.WriteLine("Incorreto");	
           	}
           	Console.ReadKey(true);
        }
    }
