using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            

            Console.WriteLine("Viska täring!");
            Console.ReadLine();
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 7);
            Console.WriteLine($"Mängija üks sai {myRandomNumber}.");
            Console.ReadLine();
           
            
            Console.WriteLine("Viska täring!");
            Console.ReadLine();
            Random rnd1 = new Random();
            int myRandomNumber1 = rnd.Next(1, 7);
            Console.WriteLine($"Mängija kaks sai {myRandomNumber1}.");
            Console.ReadLine();

            if (myRandomNumber > myRandomNumber1)
            {
                Console.WriteLine("Mängija 1 võitis!");
            }
            else if (myRandomNumber < myRandomNumber1)
            {
                Console.WriteLine("Mängija 2  võitis!");
            }
            else
            {
                Console.WriteLine("Viik");
            }


        }
    }
}
