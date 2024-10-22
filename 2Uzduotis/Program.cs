using System;

namespace AntraUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite amžių: ");
            int amzius = int.Parse(Console.ReadLine());
            if (amzius < 13)
            {
                Console.WriteLine("Jūs esate vaikas");
            } else if (amzius < 18) 
            {
                Console.WriteLine("Jūs esate paauglys");
            } else if (amzius >= 65)
            {
                Console.WriteLine("Jūs esate senjoras");
            }
        }
    }
}