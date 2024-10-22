using System;

namespace PenkioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            int temperatura = random.Next(-30, 40);

            switch(temperatura)
            {
                case int n when (n < -10):
                    Console.WriteLine("Pranesama stipri salna");
                    break;

                case int n when (n >= -10 && n <= 0):
                    Console.WriteLine("Salta");
                    break;

                case int n when (n >= 1 && n <= 15):
                    Console.WriteLine("Vesu");
                    break;

                case int n when (n > 15 && n <= 25):
                    Console.WriteLine("Silta");
                    break;

                case int n when (n > 25):
                    Console.WriteLine("Karsta");
                    break;
            }
        }
    }
}