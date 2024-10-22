using System;

namespace KetvirtaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Parašykite anglišką raidę: ");
            char raide = char.Parse(Console.ReadLine().ToLower());

            if (raide == 'a' || raide == 'e' || raide == 'i' || raide == 'o' || raide == 'u')
            {
                Console.WriteLine($"Raidė '{raide}' yra balsė.");
            }
            else
            {
                Console.WriteLine($"Raidė '{raide}' yra priebalsė.");
            }
        }
    }
}