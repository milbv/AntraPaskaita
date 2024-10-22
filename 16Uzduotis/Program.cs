using System;

namespace SesioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int skaicius = random.Next(1, 100);
            switch(skaicius)
            {
                case int n when (n <= 20):
                    Console.WriteLine($"Bilieto numeris: {skaicius}. Laimeta maza premija");
                    break;

                case int n when (n >= 20 && n <= 50):
                    Console.WriteLine($"Bilieto numeris: {skaicius}. Laimeta vidutine premija");
                    break;

                case int n when (n >= 51 && n <= 90):
                    Console.WriteLine($"Bilieto numeris: {skaicius}. Laimeta didele premija");
                    break;

                case int n when (n >= 91):
                    Console.WriteLine($"Bilieto numeris: {skaicius}.. \"Jackpot\"");
                    break;
            }

        }
        
    }
}