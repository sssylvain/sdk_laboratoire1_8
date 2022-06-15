// See https://aka.ms/new-console-template for more information

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Inserez la lettre :");
                String Note = Console.ReadLine().ToUpper();

                if (Note == "A")
                {
                    Console.WriteLine("LA");
                }
                else if (Note == "B")
                {
                    Console.WriteLine("SI");
                }
                else if (Note == "C")
                {
                    Console.WriteLine("DO");
                }
                else if (Note == "D")
                {
                    Console.WriteLine("RE");
                }
                else if (Note == "E")
                {
                    Console.WriteLine("MI");
                }
                else if (Note == "F")
                {
                    Console.WriteLine("FA");
                }
                else if (Note == "G")
                {
                    Console.WriteLine("SOL");
                }
                else
                {
                    Console.WriteLine("La note choisi n'existe pas. Essayer encore");
                }
                Console.WriteLine("Avez vous une autre lettre a convertir ? \n O = Oui \n N = Non");
            } while (Console.ReadLine().ToUpper() == "O");
            Console.WriteLine("Bye bye");
            Console.ReadKey();
        }
    }
}
