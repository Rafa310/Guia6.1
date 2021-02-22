using System;

namespace Ejercicio1Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Tabla de multiplicar.";
            Console.WriteLine("Inserte el número del cual desea saber la tabla de multiplicar del 1 al 10.");
            Double num, res;
            int n;
            num = Double.Parse(Console.ReadLine());
            for (n=0;n<=10;n=n+1)
            {
                res = num * n;
                Console.WriteLine("\nEl valor escrito {" + num + "} multiplicado por: "+n+" es " +res);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
