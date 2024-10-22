using System;

namespace PirmaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Skaičiaus tikrinimas, ar jis lyginis ar nelyginis\n Įveskite skaičių: ");
            int skaicius = int.Parse(Console.ReadLine());

            if ( skaicius % 2 == 0 )
            {
                Console.WriteLine("Skaičius yra lyginis");
            } else
            {
                Console.WriteLine("Skaičius yra nelyginis");
            }
        }
    }
}