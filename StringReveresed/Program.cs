using System;

namespace StringReveresed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm kuvab kasutajanime tagurpidi
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
    }
}
