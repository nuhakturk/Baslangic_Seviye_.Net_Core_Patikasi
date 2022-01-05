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
            //Sayı girişi döngüsü
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

            //Kullanıcıdan alınan sayıların diziye aktarılması
            uint[] pozSayiDizisi = new uint[n]; //dizi büyüklüğü == n
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Sayıyı giriniz: ", i + 1);
                pozSayiDizisi[i] = uint.Parse(Console.ReadLine());
            }

            //Dizideki elemanları foreach ile döndürüp çift olanları yazdırma.
            Console.WriteLine("Girmiş olduğunuz çift sayılar: \n");
            foreach (var cift in pozSayiDizisi)
            {
                if (cift%2 == 0)
                {
                    Console.WriteLine("- " + cift);
                }
            }

            //************** 2. Soru **************
            Console.WriteLine("\n************** 2. Soru **************");
            //************** 3. Soru **************
            Console.WriteLine("\n************** 3. Soru **************");
            //************** 4. Soru **************
            Console.WriteLine("\n************** 4. Soru **************");
        }
    }
}
