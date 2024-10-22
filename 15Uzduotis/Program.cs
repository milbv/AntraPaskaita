using System;

namespace PenkioliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite, kokio dydzio kambario buta norite issinuomouoti: ");
            string dydis = Console.ReadLine();
            Console.WriteLine("Kokia yra buto nuomos kaina, eur/men?");
            int nuoma = int.Parse(Console.ReadLine());
            if (dydis == "vieno" || dydis == "1")
            {
                if (nuoma < 500)
                {
                    Console.WriteLine("Yra galimybe issinuomuoti buta");
                } else
                {
                    Console.WriteLine("Butas gali buti per brangus");
                }
            } else if (dydis == "2" || dydis == "dvieju" || dydis == "3" || dydis == "triju") {
                if (nuoma < 1000) {
                    Console.WriteLine("Butas yra prieinamas, taciau gali buti papildomu mokesciu");
                } else
                {
                    Console.WriteLine("Butas gali buti per brangus");
                }
            }
        }
    }
}