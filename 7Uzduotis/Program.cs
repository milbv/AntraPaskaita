using System;

namespace SeptintaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite el pasto adresa: ");
            string pastas = Console.ReadLine();
            if (pastas.Contains('@') && pastas.Contains('.') && pastas != "")
            {
                Console.WriteLine($"{pastas} yra el pasto adresas");
            } else
            {
                Console.WriteLine($"{pastas} nera el pasto adresas");
            }
        }
    }
}