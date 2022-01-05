using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //**************************** 1. Soru ****************************
            Console.WriteLine("************** 1. Soru **************\n");

            uint n = 0;
            //Sayı girişi
            n = pozitifSayiAl(n, "Pozitif bir sayı giriniz");
            Console.WriteLine("Lütfen {0} adet sayı giriniz!\n", n);

            //Kullanıcıdan alınan sayıların diziye aktarılması
            uint[] pozSayiDizisi = new uint[n]; //dizi büyüklüğü == n
            pozSayiDizisi = diziyeSayiAl(n, pozSayiDizisi);

            //Dizideki elemanları foreach ile döndürüp çift olanları yazdırma.
            Console.WriteLine("Girmiş olduğunuz çift sayılar: \n");
            Program instance = new();
            instance.diziYazdirCift(pozSayiDizisi);

            //**************************** 2. Soru ****************************
            Console.WriteLine("\n************** 2. Soru **************");

            n = 0;
            uint m = 0;
            Console.WriteLine("Lütfen 2 adet pozitif sayı giriniz: ");
            //n için sayı girişi
            n = pozitifSayiAl(n, "1. sayıyı giriniz");
            //m için sayı girişi
            m = pozitifSayiAl(m, "2. sayıyı giriniz");
            Console.WriteLine("Lütfen {0} adet sayı giriniz!\n", n);

            //Kullanıcıdan alınan sayıların diziye aktarılması
            uint[] pozSayiDizisi2 = new uint[n]; //dizi büyüklüğü == n
            pozSayiDizisi2 = diziyeSayiAl(n, pozSayiDizisi2);

            //Dizideki elemanları foreach ile döndürüp m ye eşit yada tam bölünenleri yazdırma.
            Console.WriteLine("\nGirdiğiniz 2. Sayıya eşit yada tam bölünen sayılar: \n");
            instance.diziYazdirETBolunen(pozSayiDizisi2, m);

            //**************************** 3. Soru ****************************
            Console.WriteLine("\n************** 3. Soru **************");

            n = 0;
            //Sayı girişi
            n = pozitifSayiAl(n, "Pozitif bir sayı giriniz");
            Console.WriteLine("Lütfen {0} adet kelime giriniz!\n", n);

            //Diziye kelime girişi
            string[] kelimeler = new string[n]; //dizi büyüklüğü == n
            kelimeler = diziyeKelimeAl(n, kelimeler);

            //Dizi elemanlarını tersine çevirip yazdırma.
            Array.Reverse(kelimeler);
            Console.WriteLine("\nTersten yazdırılan girdiğiniz kelimeler: \n");
            instance.diziYazdirKelime(kelimeler);

            //**************************** 4. Soru ****************************
            Console.WriteLine("\n************** 4. Soru **************");
        }
        //**************************** Metodlar ****************************
        //Kullanıcıdan yalnızca pozitif sayı alır.
        public static uint pozitifSayiAl(uint sayi, string cumle)
        {
            do
            {
                try
                {
                    Console.Write(cumle + ": ");
                    sayi = uint.Parse(Console.ReadLine());
                    if (sayi == 0)
                    {
                        Console.WriteLine("0 Sayısını giremezsiniz Tekrar Deneyin!\n");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız. Hata: {0}", ex.Message + "\n");
                }
            } while (sayi < 1);
            return sayi;
        }

        //Dizinin elemanlarına sayı kaydeder.
        public static uint[] diziyeSayiAl(uint diziBuyuklugu, uint[] dizi)
        {
            for (int i = 0; i < diziBuyuklugu; i++)
            {
                do
                {
                    try
                    {
                        Console.Write("{0}. Sayıyı giriniz: ", i + 1);
                        dizi[i] = uint.Parse(Console.ReadLine());
                        if (dizi[i] == 0)
                        {
                            Console.WriteLine("0 Sayısını giremezsiniz Tekrar Deneyin!\n");
                        }
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("Hatalı bir giriş yaptınız. Hata: {0}", e.Message + "\n");
                    }

                } while (dizi[i] < 1);
            }
            return dizi;
        }

        //Dizinin elemanlarına kelime kaydeder.
        public static string[] diziyeKelimeAl(uint diziBuyuklugu, string[] dizi)
        {
            string veri;
            for (int i = 0; i < diziBuyuklugu; i++)
            {
                do
                {
                    Console.Write("{0}. Kelimeyi giriniz: ", i + 1);
                    veri = Console.ReadLine();
                    if (String.IsNullOrEmpty(veri))
                    {
                        Console.WriteLine("Boş Giriş yapamazsınız!\n");
                    }
                } while (String.IsNullOrEmpty(veri));
                dizi[i] = veri;
            }
            return dizi;
        }

        //Dizideki çift sayıları ekrana yazdırır.
        public void diziYazdirCift(uint[] dizi)
        {
            foreach (var cift in dizi)
            {
                if (cift % 2 == 0)
                {
                    Console.WriteLine("- " + cift);
                }
            }
        }

        //Dizideki eşit veya tam bölünen sayıları ekrana yazdırır.
        public void diziYazdirETBolunen(uint[] dizi, uint bSayi)
        {
            foreach (var item in dizi)
            {
                if (item == bSayi || item % bSayi == 0)
                {
                    Console.WriteLine("- " + item);
                }
            }
        }

        //Dizideki elemanları yazdırır.
        public void diziYazdirKelime(string[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
