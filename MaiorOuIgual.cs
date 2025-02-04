using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            float y = float.Parse(Console.ReadLine());
           	
           	
            if (x > y) {	
            Console.WriteLine("O número primeiro é maior que o segundo");
            } 
	    else if (x == y) {
            Console.WriteLine("Os números são iguais");	
            } else {
            Console.WriteLine("Incorreto");
	    }
           	Console.ReadKey(true);
        }
    }
