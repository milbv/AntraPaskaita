using System;

namespace VienuoliktaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu: ");
            int amzius = int.Parse(Console.ReadLine());
            if (amzius >= 18 && amzius <= 30)
            {
                Console.WriteLine("Ar esate studentas ar dirbate?");
                string darboPadetis = Console.ReadLine();
                if (darboPadetis == "studentas"  || darboPadetis == "studijuoju" || darboPadetis == "studijos")
                {
                    Console.WriteLine("Jus galite pretenduoti i akademine parama");
                } else if (darboPadetis == "dirbu" || darboPadetis == "darbas")
                {
                    Console.WriteLine("Jus galite pretenduoti i stipendija");
                }
            }
        }
    }
}