using System;

namespace Ucgen_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen çizmek için 3 tane kenar girişi yapın!");
            UcgenCiz();
        }
        static void UcgenCiz()
        {
            int a, b, c;
            
            Console.Write("a Kenarı: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b Kenarı: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c Kenarı: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a+b > c && a+c > b && c+b > a)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 2*10; j++)
                    {
                        if (j == (10 - i + 1) || j == (10 + i - 1))
                        {
                            Console.Write("* ");
                        }
                        else if (i == 10)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                    }
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Üçgen çizilemez tekrar deneyin!");
            }
        }
    }
}
