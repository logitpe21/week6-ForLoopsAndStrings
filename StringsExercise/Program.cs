﻿using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello Wrold!";

            //programm kuvab konsoolis sõne esimest tähte ja viimast tähte

            //kuvame esimest tähte
            Console.WriteLine(helloWorld[0]);
            //kuvame viimast tähte
            Console.WriteLine(helloWorld[helloWorld.Length-1]);


        }
    }
}
