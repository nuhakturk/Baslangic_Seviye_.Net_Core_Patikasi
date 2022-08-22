using System;

namespace Ortalama_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int derinlik;
            Console.Write("Fibonacci dizisinin derinliği ne kadar olsun = ");
            derinlik = Convert.ToInt32(Console.ReadLine());
            FibonacciOrt(derinlik);
        }

        static void FibonacciOrt(int derinlik)
        {
            int a = 0;
            int b = 1;
            Console.Write("{0} {1} ",a ,b);
            int toplam = a + b;

            for (int i = 3; i <= derinlik; i++)
            {
                int c = a + b;
                Console.Write("{0} ",c);
                toplam += c;
                a = b;
                b = c;
            }
            Console.WriteLine("\nOrtalama: {0}",toplam/derinlik);
        }
    }
}
