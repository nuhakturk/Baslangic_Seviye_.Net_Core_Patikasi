using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int asalMi = 0;
            int sayi = 0;
            ArrayList sayiListesi = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();

            //Sayı Girişi
            for (int i = 1; i < 21; i++)
            {
                bool kontrol = true;
                while (kontrol)
                {
                    Console.Write("{0}. Sayıyı giriniz:",i);
                    
                    try
                    {
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if(sayi > -1){
                            sayiListesi.Add(sayi);
                            kontrol = false;
                        }
                        else{
                            Console.WriteLine("Negatif yada geçersiz değer girdiniz.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Bir hata oluştu lütfen sadece pozitif sayı girin. Hata: " + e.Message);
                    }
                }
            }

            //Asal kontrolü
            for (int i = 0; i < sayiListesi.Count; i++)
            {
                for (int j = 2; j < (int)sayiListesi[i]; j++)
                {
                    if((int)sayiListesi[i] % j == 0 && (int)sayiListesi[i] != 2)
                    {
                        asalMi++;
                    }
                }
                if (asalMi != 0 || (int)sayiListesi[i] == 1 || (int)sayiListesi[i] == 0)
                {
                    asalDegil.Add(sayiListesi[i]);
                }
                else{
                    asal.Add(sayiListesi[i]);
                }
                asalMi = 0;
            }

            //ArrayLists Sort
            asal.Sort();
            asal.Reverse();
            asalDegil.Sort();
            asalDegil.Reverse();
            
            //Asal Sayılar listesi
            Console.WriteLine("\nAsal Sayılar:");
            foreach (var item in asal)
            {
                Console.WriteLine(item);
            }
            
            //Asal Olmayan sayılar listesi
            Console.WriteLine("\nAsal Sayı olmayanlar:");
            foreach (var item in asalDegil)
            {
                Console.WriteLine(item);
            }

            //ASAL SAYILAR eleman sayısı ve ortalaması 
            Console.WriteLine("\nAsal sayılar listesi eleman sayısı: {0}",asal.Count);
            //Ortalama hesaplama
            int listeToplam = 0;
            foreach (var item in asal)
            {
                listeToplam += (int)item;
            }
            Console.WriteLine("\nAsal sayılar listesi ortalaması: {0}",(listeToplam/asal.Count));
            listeToplam = 0;
            //*******************************************************************************

            //ASAL OLMAYAN SAYILAR eleman sayısı ve ortalaması
            Console.WriteLine("\nAsal olmayan sayılar listesi eleman sayısı: {0}",(asalDegil.Count));
            //Ortalama hesaplama
            foreach (var item in asalDegil)
            {
                listeToplam += (int)item;
            }
            Console.WriteLine("\nAsal olmayan sayılar listesi ortalaması: {0}",(listeToplam/asalDegil.Count));
        }
    }
}
