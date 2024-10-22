using System;

namespace SestaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            if (vardas.Length > 5)
            {
                Console.WriteLine($"{vardas} yra ilgesnis nei 5 simboliai");
            } else
            {
                Console.WriteLine($"{vardas} yra trumpesnis ar 5 simboliu ilgio");
            }
        }
    }
}