using System;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            string sesli = "aeıioöuü";
            char[] olanlar = new char[8];

            //Cümle girişi
            Console.Write("Bir cümle giriniz: ");
            cumle = Console.ReadLine();
            Console.WriteLine("Yazdığınız cümle: " + cumle);

            cumle.ToLower();

            //sesli harf kontrol
            int sayac = 0;
            foreach (var item in sesli)
            {
                foreach (var item2 in cumle)
                {
                    if (item == item2)
                    {
                        olanlar[sayac] = item;
                        sayac++;
                        break;
                    }
                }
            }

            //Dizi boyutu düzenleme ve sıralama
            Array.Resize(ref olanlar, sayac);
            Array.Sort(olanlar);


            Console.WriteLine("\nOlan sesli harfler: ");
            foreach (var item in olanlar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
