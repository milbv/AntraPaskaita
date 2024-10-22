using System;

namespace KeturioliktaUzduotis 
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pateikite metines pajamas eurais: ");
            int pajamos = int.Parse(Console.ReadLine());
            Console.WriteLine("Pateikite esamus finansinius isipareigojimus eurais:");
            int islaidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Pateikite darbo staza (metais)");
            int stazas = int.Parse(Console.ReadLine());

            if (pajamos > 25000 && islaidos < (pajamos * 0.4))
            {
                if (stazas > 2)
                {
                    Console.WriteLine("Turite gera galimybe gauti paskola!");
                } else if (stazas <= 2)
                {
                    Console.WriteLine("Jums reikia daugiau laiko norint gauti gera paskola");
                }
            } else
            {
                Console.WriteLine("Jus galite tureti sunkumu gaunant paskola");
            }
        }
    }
}