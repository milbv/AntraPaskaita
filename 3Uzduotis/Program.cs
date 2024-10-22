using System;

namespace TreciaUzduotis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Įveskite dienos numerį: ");
            int diena = int.Parse(Console.ReadLine());

            switch(diena)
            {
                case 1:
                    Console.WriteLine("Šiandien yra pirmadienis.");
                    break;
                case 2:
                    Console.WriteLine("Šiandien yra antradienis.");
                    break;
                case 3:
                    Console.WriteLine("Šiandien yra trečiadienis.");
                    break;
                case 4:
                    Console.WriteLine("Šiandien yra ketvirtadienis.");
                    break;
                case 5:
                    Console.WriteLine("Šiandien yra penktadienis.");
                    break;
                case 6:
                    Console.WriteLine("Šiandien yra šeštadienis.");
                    break;
                case 7:
                    Console.WriteLine("Šiandien yra sekmadienis.");
                    break;
            }
        }
    }
}