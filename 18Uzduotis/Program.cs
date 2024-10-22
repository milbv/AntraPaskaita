using System;

namespace AstuonioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int laikas = rnd.Next(0, 23);
            string rekomendacija = "";

            switch(laikas)
            {
                case int n when (n >= 6 && n < 10):
                    rekomendacija = "Rekomenduojame stipria juoda kava";
                    break;

                case int n when (n >= 10 && n < 14):
                    rekomendacija = "Rekomenduojame latte ar cappucino";
                    break;

                case int n when (n >= 14 && n < 18):
                    rekomendacija = "Rekomenduojame espressor ar salta kava";
                    break;

                case int n when (n >= 18):
                    rekomendacija = "Rekomenduojame vengti kavos arba rinktis kava be kofeino";
                    break;
            }
            Console.WriteLine($"{rekomendacija}. Ar noretumete kavos su cukrumi?");
            if (Console.ReadLine() == "taip")
            {
                Console.WriteLine("Idejome i jusu kava cukraus, skanaus!");
            } else if (Console.ReadLine() == "ne")
            {
                Console.WriteLine("Tokia kava po 18 val. gali sutrikdyti miega, jei ji vartomaja vakare.");
            }
        }
    }
}