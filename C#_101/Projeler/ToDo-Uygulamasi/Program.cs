using System;
using System.Collections.Generic;

namespace ToDo_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kişiler listesi ve elemanları
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi(){Id = 1, Ad = "Nuh", Soyad = "Aktürk"});
            kisiler.Add(new Kisi(){Id = 2, Ad = "Ahmet", Soyad = "Demir"});
            kisiler.Add(new Kisi(){Id = 3, Ad = "Ayşe", Soyad = "Yıldız"});

            //Liste ve Todo kolonunda 3 tane kart
            List<Line> lines = new List<Line>();
            lines.Add(new Line(){Kolon = 1, Baslik = "Yemek", Icerik = "Akşam yemeği olarak imam bayıldı yap.", KisiID = 2, Buyukluk = 3});
            lines.Add(new Line(){Kolon = 1, Baslik = "Kod Yaz", Icerik = "Patika projeni bitir.", KisiID = 1, Buyukluk = 4});
            lines.Add(new Line(){Kolon = 1, Baslik = "Spor", Icerik = "Sabah koşusuna çık.", KisiID = 3, Buyukluk = 2});
            
            int secim;
            bool kontrol = true;
            while (kontrol)
            {
                AnaSayfa();
                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                    if(secim > 0 || secim < 5)
                    {
                        switch (secim)
                        {
                            case 1:
                                Listele(lines, kisiler);
                                break;
                            case 2:
                                Ekle(lines, kisiler);
                                break;
                            case 3:
                                Sil(lines, kisiler);
                                break;
                            case 4:
                                Tasi(lines, kisiler);
                                break;
                        }
                    }
                    else{
                        Console.WriteLine("Geçersiz değer girdiniz!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata oluştu lütfen sadece pozitif sayı girin. Hata: " + e.Message);
                }
            }
        }

        
        static void AnaSayfa()
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.Write("Seçiminiz <1 - 4> : ");
        }
        
        static void Listele(List<Line> lines, List<Kisi> kisiler)
        {
            bool bosIse = true;

            //****************** TODO Line ******************
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("************************");
            foreach (var item in lines)
            {
                if (item.Kolon == 1)
                {
                    Console.WriteLine("Başlık      : {0}", item.Baslik);
                    Console.WriteLine("İçerik      : {0}", item.Icerik);
                    foreach (var kisi in kisiler)
                    {
                        if (kisi.Id == item.KisiID)
                        {
                            Console.WriteLine("Atanan Kişi : {0} {1}", kisi.Ad, kisi.Soyad);
                            break;
                        }
                    }
                    switch (item.Buyukluk)
                    {
                        case 1:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XS);
                            break;
                        case 2:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.S);
                            break;
                        case 3:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.M);
                            break;
                        case 4:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.L);
                            break;
                        case 5:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XL);
                            break;
                    }
                    Console.WriteLine("-");
                    bosIse = false;
                }
            }
            if (bosIse)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            bosIse = true;
            Console.WriteLine();
            Console.WriteLine();

            //****************** InProgress Line ******************
            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (var item in lines)
            {
                if (item.Kolon == 2)
                {
                    Console.WriteLine("Başlık      : {0}", item.Baslik);
                    Console.WriteLine("İçerik      : {0}", item.Icerik);
                    foreach (var kisi in kisiler)
                    {
                        if (kisi.Id == item.KisiID)
                        {
                            Console.WriteLine("Atanan Kişi : {0} {1}", kisi.Ad, kisi.Soyad);
                            break;
                        }
                    }
                    switch (item.Buyukluk)
                    {
                        case 1:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XS);
                            break;
                        case 2:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.S);
                            break;
                        case 3:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.M);
                            break;
                        case 4:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.L);
                            break;
                        case 5:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XL);
                            break;
                    }
                    Console.WriteLine("-");
                    bosIse = false;
                }
            }
            if (bosIse)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            bosIse = true;
            Console.WriteLine();
            Console.WriteLine();

            //****************** Done Line ******************
            Console.WriteLine("\nDONE Line");
            Console.WriteLine("************************");
            foreach (var item in lines)
            {
                if (item.Kolon == 3)
                {
                    Console.WriteLine("Başlık      : {0}", item.Baslik);
                    Console.WriteLine("İçerik      : {0}", item.Icerik);
                    foreach (var kisi in kisiler)
                    {
                        if (kisi.Id == item.KisiID)
                        {
                            Console.WriteLine("Atanan Kişi : {0} {1}", kisi.Ad, kisi.Soyad);
                            break;
                        }
                    }
                    switch (item.Buyukluk)
                    {
                        case 1:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XS);
                            break;
                        case 2:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.S);
                            break;
                        case 3:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.M);
                            break;
                        case 4:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.L);
                            break;
                        case 5:
                            Console.WriteLine("Büyüklük    : {0}",Buyukluk.XL);
                            break;
                    }
                    Console.WriteLine("-");
                    bosIse = false;
                }
            }
            if (bosIse)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Ekle(List<Line> linelar, List<Kisi> kisiler)
        {
            string baslikEkle = "";
            string icerikEkle = "";
            int buyuklukEkle = 0;
            int kisiEkle = 0;
            bool ekleSecim = true;
            Console.WriteLine("\n*************************************************");
            Console.Write("Başlık Giriniz                                  : ");
            baslikEkle = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            icerikEkle = Console.ReadLine();
            while (ekleSecim)
            {
                Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
                try
                {
                    buyuklukEkle = Convert.ToInt32(Console.ReadLine());
                    if (0 < buyuklukEkle && buyuklukEkle < 6)
                    {
                        ekleSecim = false;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz değer girdiniz, tekrar deneyiniz.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata oluştu lütfen sadece pozitif sayı girin. Hata: " + e.Message);
                }
            }

            Console.WriteLine("******************Kişiler********************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("{0} {1} - {2}", item.Ad, item.Soyad, item.Id);
            }
            ekleSecim = true;
            while (ekleSecim)
            {
                Console.Write("Kişi Seçiniz(ID numarasını yazınız)             : ");
                try
                {
                    kisiEkle = Convert.ToInt32(Console.ReadLine());
                    if (0 < kisiEkle && kisiEkle < 4)
                    {
                        ekleSecim = false;
                        linelar.Add(new Line(){Kolon = 1, Baslik = baslikEkle, Icerik = icerikEkle, KisiID = kisiEkle, Buyukluk = buyuklukEkle});
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz değer girdiniz, tekrar deneyiniz.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata oluştu lütfen sadece pozitif sayı girin. Hata: " + e.Message);
                }
            }
        }

        static void Sil(List<Line> lines, List<Kisi> kisiler)
        {
            string kartBaslik;
            bool secimSil = true;
            bool kartYokise = true;
            int silSecim;
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            while (secimSil)
            {
                Console.Write("Lütfen kart başlığını yazınız: ");
                try
                {
                    kartBaslik = Console.ReadLine();
                    foreach (var item in lines)
                    {
                        if (kartBaslik == item.Baslik)
                        {
                            Console.WriteLine("Bulunan Kart Bilgileri");
                            Console.WriteLine("**********************************");
                            Console.WriteLine("Başlık      : {0}", item.Baslik);
                            Console.WriteLine("İçerik      : {0}", item.Icerik);
                            foreach (var kisi in kisiler)
                            {
                                if (kisi.Id == item.KisiID)
                                {
                                    Console.WriteLine("Atanan Kişi : {0} {1}", kisi.Ad, kisi.Soyad);
                                    break;
                                }
                            }
                            switch (item.Buyukluk)
                            {
                                case 1:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.XS);
                                    break;
                                case 2:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.S);
                                    break;
                                case 3:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.M);
                                    break;
                                case 4:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.L);
                                    break;
                                case 5:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.XL);
                                    break;
                            }
                            switch (item.Kolon)
                            {
                                case 1:
                                    Console.WriteLine("Line        : {0}", Kolon.todo);
                                    break;
                                case 2:
                                    Console.WriteLine("Line        : {0}", Kolon.inProgress);
                                    break;
                                case 3:
                                    Console.WriteLine("Line        : {0}", Kolon.done);
                                    break;
                            }

                            Console.Write("\nKartı silmek istiyor musunuz?(y/n): ");
                            string yORn = Console.ReadLine();
                            if (yORn == "y")
                            {
                                Console.WriteLine("\"{0}\" Başlıklı kart başarıyla silindi.",item.Baslik);
                                lines.RemoveAt(lines.IndexOf(item));
                                secimSil = false;
                                kartYokise = false;
                                break;
                            }
                            else if(yORn == "n")
                            {
                                secimSil = false;
                                kartYokise = false;
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yanlış değer girdiniz tekrar deneyin.");
                                secimSil = false;
                                kartYokise = false;
                                continue;
                            }
                        }
                    }
                    if (kartYokise)
                    {
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        bool kayitYokiseALT = true;
                        while (kayitYokiseALT)
                        {
                            Console.Write("Seçiminiz <1 - 2> : ");
                            try
                            {
                                silSecim = Convert.ToInt32(Console.ReadLine());
                                switch (silSecim)
                                {
                                    case 1:
                                        kayitYokiseALT = false;
                                        secimSil = false;
                                        break;
                                    case 2:
                                        kayitYokiseALT = false;
                                        break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Yanlış bir değer girdiniz. Lütfen 1 veya 2 değerini giriniz. Hata: {0}", e.Message); 
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata oluştu. Hata: " + e.Message);
                }
            }
        }

        static void Tasi(List<Line> lines, List<Kisi> kisiler)
        {
            string kartBaslik;
            bool secimTasi = true;
            bool kartYokise = true;
            int tasiSecim;
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            while (secimTasi)
            {
                Console.Write("Lütfen kart başlığını yazınız: ");
                try
                {
                    kartBaslik = Console.ReadLine();
                    foreach (var item in lines)
                    {
                        if (kartBaslik == item.Baslik)
                        {
                            Console.WriteLine("Bulunan Kart Bilgileri:");
                            Console.WriteLine("**********************************");
                            Console.WriteLine("Başlık      : {0}", item.Baslik);
                            Console.WriteLine("İçerik      : {0}", item.Icerik);
                            foreach (var kisi in kisiler)
                            {
                                if (kisi.Id == item.KisiID)
                                {
                                    Console.WriteLine("Atanan Kişi : {0} {1}", kisi.Ad, kisi.Soyad);
                                    break;
                                }
                            }
                            switch (item.Buyukluk)
                            {
                                case 1:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.XS);
                                    break;
                                case 2:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.S);
                                    break;
                                case 3:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.M);
                                    break;
                                case 4:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.L);
                                    break;
                                case 5:
                                    Console.WriteLine("Büyüklük    : {0}", Buyukluk.XL);
                                    break;
                            }
                            switch (item.Kolon)
                            {
                                case 1:
                                    Console.WriteLine("Line        : {0}", Kolon.todo);
                                    break;
                                case 2:
                                    Console.WriteLine("Line        : {0}", Kolon.inProgress);
                                    break;
                                case 3:
                                    Console.WriteLine("Line        : {0}", Kolon.done);
                                    break;
                            }

                            Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz:");
                            Console.WriteLine("(1) TODO");
                            Console.WriteLine("(2) IN PROGRESS");
                            Console.WriteLine("(3) DONE");
                            bool kayitYokiseALT = true;
                            while (kayitYokiseALT)
                            {
                                Console.Write("Seçiminiz <1 - 3> : ");
                                try
                                {
                                    int lineTasi = Convert.ToInt32(Console.ReadLine());
                                    switch (lineTasi)
                                    {
                                        case 1:
                                            item.Kolon = 1;
                                            kayitYokiseALT = false;
                                            secimTasi = false;
                                            kartYokise = false;
                                            break;
                                        case 2:
                                            item.Kolon = 2;
                                            kayitYokiseALT = false;
                                            secimTasi = false;
                                            kartYokise = false;
                                            break;
                                        case 3:
                                            item.Kolon = 3;
                                            kayitYokiseALT = false;
                                            secimTasi = false;
                                            kartYokise = false;
                                            break;
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Yanlış bir değer girdiniz. Lütfen 1, 2 veya 3 değerini giriniz. Hata: {0}", e.Message); 
                                }
                            }
                        }
                    }
                    if (kartYokise)
                    {
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için       : (2)");
                        bool kayitYokiseALT = true;
                        while (kayitYokiseALT)
                        {
                            Console.Write("Seçiminiz <1 - 2> : ");
                            try
                            {
                                tasiSecim = Convert.ToInt32(Console.ReadLine());
                                switch (tasiSecim)
                                {
                                    case 1:
                                        kayitYokiseALT = false;
                                        secimTasi = false;
                                        break;
                                    case 2:
                                        kayitYokiseALT = false;
                                        break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Yanlış bir değer girdiniz. Lütfen 1 veya 2 değerini giriniz. Hata: {0}", e.Message); 
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bir hata oluştu. Hata: " + e.Message);
                }
            }
        }
    }
    enum Kolon
    {
        todo=1,
        inProgress,
        done
    }

    enum Buyukluk
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
