using System;

namespace DevintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            double skaicius = double.Parse(Console.ReadLine());
            if (skaicius > 9)
            {
                Console.WriteLine("Skaicius yra teigiamas dvizenklis.");
            }
            else if (skaicius > 0)
            {
                Console.WriteLine("Skaicius yra teigiamas");
            }
            else
            {
                Console.WriteLine("Skaicius yra neigamas");
            }
        }
    }
}