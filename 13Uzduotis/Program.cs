using System;

namespace TryliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int skaicius = int.Parse(Console.ReadLine());

            if (skaicius > 100)
            {
                if (skaicius % 10 == 0)
                {
                    Console.WriteLine("Skaicius yra ypatingas");
                } else
                {
                    Console.WriteLine("Skaicius yra paprastas");
                }
            } else
            {
                Console.WriteLine("Skaicius yra per mazas");
            }
        }
    }
}