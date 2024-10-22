using System;

namespace DesimtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            int skaicius = int.Parse(Console.ReadLine());

            if (skaicius % 2 == 0)
            {
                if (skaicius > 20)
                {
                    if (skaicius % 4 == 0)
                    {
                        Console.WriteLine("Skaicius yra didelis lyginis");
                    } else
                    {
                        Console.WriteLine("...");
                    }
                }
                else
                {
                    Console.WriteLine("Skaicius yra mazas lyginis");
                }
            }
        }
    }
}