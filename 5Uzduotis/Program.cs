using System;

namespace PenktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma skaiciu: ");
            double pirma = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            double antra = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia skaiciu: ");
            double trecia = double.Parse(Console.ReadLine());

            if (pirma + antra > trecia && pirma + trecia > antra && antra + trecia > pirma)
            {
                Console.WriteLine("Su siomis krastinemis gali buti sudarytas trikampis");
            } else
            {
                Console.WriteLine("Trikampis negali buti sudaryti su siomis krastinemis");
            }
        }
    }
}