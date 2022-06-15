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
                //lusager doit enter une lettre afin dobtenir une note musicale qui est attribuee a la valeur de la lettre//
                Console.WriteLine("Inserez une lettre entre A et G elle sera convertie en note musicale :");
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
                    //messagederreur//
                    Console.WriteLine("La note choisie n'existe pas. Essayer encore");
                }
                //demande si lusager veut continuer de jouer//
                Console.WriteLine("Avez vous une autre lettre a convertir ? \n O = Oui \n N = Non");
            } while (Console.ReadLine().ToUpper() == "O");
            Console.WriteLine("Bye bye");
            Console.ReadKey();
        }
    }
}
