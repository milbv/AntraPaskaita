using System;

namespace AstuntaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu");
            int pirmas = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu");
            int antras = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu");
            int trecias = int.Parse(Console.ReadLine());

            if ( (pirmas == antras || pirmas == trecias || antras == trecias) && (pirmas + antras > trecias || pirmas + trecias > antras || antras + trecias > pirmas) )
            {
                Console.WriteLine("Trikampis yra lygiasonis");
            } else if (pirmas + antras > trecias || pirmas + trecias > antras || antras + trecias > pirmas)
            {
                Console.WriteLine("Sudaromas trikampis, bet ne lygiasonis");
            } else
            {
                Console.WriteLine("Nesusidaro trikampis");
            }
        }
    }
}