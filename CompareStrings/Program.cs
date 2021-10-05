using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("siseta oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if(firstName.Length > lastName.Length)
            {
                Console.WriteLine("eesnimi on pikem kui perekonnanimi.");
            }
            else if(firstName.Length < lastName.Length)
            {
                Console.WriteLine("perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Sama pikad");
            }
        }
    }
}
