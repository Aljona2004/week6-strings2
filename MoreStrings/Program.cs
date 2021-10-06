using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestda eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõpevad punktiga

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere, {firstName[0]}. {lastName[0]}.");

        }
    }
}
