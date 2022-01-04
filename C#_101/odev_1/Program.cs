using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //************** 1. Soru **************
            Console.WriteLine("************** 1. Soru **************");

            uint n = 0;
            do
            {
                try
                {
                    Console.Write("\nPozitif bir sayı giriniz: ");
                    n = uint.Parse(Console.ReadLine());
                    if (n == 0)
                    {
                        Console.WriteLine("0 Sayısını giremezsiniz Tekrar Deneyin!");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız. Hata: {0}", ex.Message);
                }
            } while (n < 1);

            uint[] pozSayiDizisi = new uint[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Sayıyı giriniz: ", i + 1);
                pozSayiDizisi[i] = uint.Parse(Console.ReadLine());
            }

            Console.WriteLine("Girmiş olduğunuz çift sayılar: \n");
            foreach (var cift in pozSayiDizisi)
            {
                if (cift%2 == 0)
                {
                    Console.WriteLine("- " + cift);
                }
            }

            //************** 2. Soru **************
            Console.WriteLine("************** 2. Soru **************");
            //************** 3. Soru **************
            Console.WriteLine("************** 3. Soru **************");
            //************** 4. Soru **************
            Console.WriteLine("************** 4. Soru **************");
        }
    }
}
