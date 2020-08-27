using System;

namespace HolaMundo_master
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCual es tu nombre? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHola, {name}, on {date:d} at {date:t}!");
            Console.Write("Presione una tecla para salir");
            Console.ReadKey(true);
        }
    }
}
