using System;
namespace DvyliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite el pasto adresa: ");
            string pastas = Console.ReadLine();
            if (pastas.Contains('@') && pastas.Contains('.') && pastas != "")
            {
                if(pastas.Contains("@gmail.com") || pastas.Contains("@yahoo.com"))
                {
                    Console.WriteLine("Jusu pastas yra populiarus el pasto tiekejas");
                } else
                {
                    Console.WriteLine("Jusu pastas yra maziau zinomas el pasto tiekejas");
                }
            }
           
        }
    }
}