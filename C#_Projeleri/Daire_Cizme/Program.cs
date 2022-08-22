using System;

namespace Daire_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daire çizmek için yarıçapı girmeniz gerekmekte!");
            DaireCiz();
        }
        static void DaireCiz()
        {
            double yaricap;
            double kalinlik = 0.4;
            char symbol = '*';
            do
            {
                Console.Write("Yarıçapı giriniz: ");
                if (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
                {
                    Console.WriteLine("Yarıçap pozitif sayı olmalıdır!");
                }
            }
            while (yaricap <= 0);
            Console.WriteLine();
            double rIn =yaricap- kalinlik, rOut = yaricap + kalinlik;
            for (double y = yaricap; y >= -yaricap; --y)
            {
                for (double x = -yaricap; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            }
        }
    }
}
