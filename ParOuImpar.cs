using System;

    class Program
    {
        public static void Main(string[] args)
        {
        	
           	Console.WriteLine("Digite o primeiro número: ");
            int x = int.Parse(Console.ReadLine());
           	
           	
            if (x % 2 == 0 ) {	
            Console.WriteLine("é par");
            } else {
            Console.WriteLine("é impar");
	    }
           	Console.ReadKey(true);
        }
    }

