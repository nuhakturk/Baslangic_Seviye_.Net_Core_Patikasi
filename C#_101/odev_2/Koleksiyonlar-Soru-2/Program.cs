using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = new int[20];
            int[] enKucuk = new int[3];
            int[] enBuyuk = new int[3];
            for (int i = 0; i < 20; i++)
            {
                bool kontrol = true;
                while (kontrol)
                {
                    try
                    {
                        Console.Write("{0}. Sayıyı giriniz:",i+1);
                        sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                        kontrol = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Yanlış değer girdiniz sadece sayı girişi yapın!. Hata: " + ex.Message);
                    }
                }
            }

            //Array Sort
            Array.Sort(sayiDizisi);

            //En küçük 3 değer
            Console.WriteLine("\nEn küçük 3 değer:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sayiDizisi[i]);
                enKucuk[i] = sayiDizisi[i];
            }
            //En büyük 3 değer
            Console.WriteLine("\nEn büyük 3 değer:");
            for (int i = 19; i > 16; i--)
            {
                Console.WriteLine(sayiDizisi[i]);
                enBuyuk[i-17] = sayiDizisi[i];
            }

            //Ortalamalar
            int ortKucuk = 0;
            int ortBuyuk = 0;
            //Küçük sayı dizisi ortalama
            foreach (var item in enKucuk)
            {
                ortKucuk += item;
            }
            //Büyük sayı dizisi ortalama
            foreach (var item in enBuyuk)
            {
                ortBuyuk += item;
            }

            ortKucuk = ortKucuk/enKucuk.Length;
            ortBuyuk = ortBuyuk/enBuyuk.Length;

            //Ortalamalar ve toplamları
            Console.WriteLine("\nKüçük sayı dizisi ortalaması: {0}",ortKucuk);
            Console.WriteLine("Büyük sayı dizisi ortalaması: {0}",ortBuyuk);
            Console.WriteLine("Ortalamaların toplamı: {0}",(ortKucuk+ortBuyuk));
        }
    }
}
