using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Console_Telefon_Rehberi_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rehber> rehber = new List<Rehber>();
            rehber.Add(new Rehber(){Isim = "Ahmet", Soyisim = "Yılmaz", Telno = "05678910123"});
            rehber.Add(new Rehber(){Isim = "Cemre", Soyisim = "Demir", Telno = "05678910123"});
            rehber.Add(new Rehber(){Isim = "Mehmet", Soyisim = "Çağlar", Telno = "05678910123"});
            rehber.Add(new Rehber(){Isim = "Bahri", Soyisim = "Sarı", Telno = "05678910123"});
            rehber.Add(new Rehber(){Isim = "Yavuz", Soyisim = "Yılmaz", Telno = "05678910123"});

            //Rehberdeki kişileri sıralar.
            rehber = rehber.OrderBy(o => o.Isim).ToList();
            
            //Seçim
            bool kontrol = true;
            int secim = 0;
            while (kontrol)
            {
                //Ana Sayfa
                AnaSayfa(rehber);
                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                    if(secim > 0 || secim < 6)
                    {
                        switch (secim)
                        {
                            case 1:
                                Kaydet(rehber);
                                break;
                            case 2:
                                Sil(rehber);
                                break;
                            case 3:
                                Guncelle(rehber);
                                break;
                            case 4:
                                Listele(rehber);
                                break;
                            case 5:
                                RehberdeAra(rehber);
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
                rehber = rehber.OrderBy(o => o.Isim).ToList();
            }



            
            // foreach (var kisi in rehber)
            // {
            //     Console.WriteLine(kisi.Isim);
            //     Console.WriteLine(kisi.Soyisim);
            //     Console.WriteLine(kisi.Telno);
            // }
        }


        static void AnaSayfa(List<Rehber> kisiler)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.Write("Seçiminiz <1 - 5> : ");
        }

        

        static void Kaydet(List<Rehber> kisi)
        {
            string ad;
            string soyad;
            string tel;
            Console.WriteLine("*******************************************");
            Console.Write("Lütfen isim giriniz              :");
            ad = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz           :");
            soyad = Console.ReadLine();
            bool kontrol = true;
            while (kontrol)
            {
                Console.Write("Lütfen telefon numarası giriniz  :"); 
                tel = Console.ReadLine();
                bool TelefonDogruMu = TelefonFormatKontrol(tel);
                if (TelefonDogruMu == true)
                {
                    kisi.Add(new Rehber(){Isim = ad, Soyisim = soyad, Telno = tel});
                    kontrol = false;
                }
                else
                {
                    tel = "";
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("Telefon numarası hatalıdır. Lütfen kontrol ediniz. (0xxxxxxxxxx) şeklinde giriniz.");
                    Console.WriteLine("***********************************************");
                }
            }
        }

        static void Sil(List<Rehber> kisi)
        {
            string adVeyaSoyad;
            int silSecim;
            bool silDongu = true;
            bool kayitYokise = true;
            while (silDongu)
            {
                Console.WriteLine("***********************************************");
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                adVeyaSoyad = Console.ReadLine();
                foreach (var item in kisi)
                {
                    if (item.Isim == adVeyaSoyad || item.Soyisim == adVeyaSoyad)
                    {
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("{0} {1} isimli {2} numaralı kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) ", item.Isim, item.Soyisim, item.Telno);
                        string yORn = Console.ReadLine();
                        if (yORn == "y")
                        {
                            Console.WriteLine("***********************************************");
                            Console.WriteLine("{0} {1} isimli kişi başarıyla silindi!.", item.Isim, item.Soyisim);
                            kisi.RemoveAt(kisi.IndexOf(item));
                            kayitYokise = false;
                            silDongu = false;
                            break;
                        }
                        else if(yORn == "n")
                        {
                            kayitYokise = false;
                            silDongu = false;
                            continue;
                        }
                        else{
                            Console.WriteLine("Yanlış değer girdiniz tekrar deneyin.");
                            kayitYokise = false;
                            silDongu = false;
                            continue;
                        }
                    }
                }
                if (kayitYokise)
                {
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
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
                                    silDongu = false;
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
        }

        static void Guncelle(List<Rehber> kisi)
        {
            string adVeyaSoyad;
            int guncelleSecim;
            bool guncelleDongu = true;
            bool kayitYokise = true;
            while (guncelleDongu)
            {
                Console.WriteLine("***********************************************");
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                adVeyaSoyad = Console.ReadLine();
                foreach (var item in kisi)
                {
                    if (item.Isim == adVeyaSoyad || item.Soyisim == adVeyaSoyad)
                    {
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("{0} {1} isimli {2} numaralı kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n) ", item.Isim, item.Soyisim, item.Telno);
                        string yORn = Console.ReadLine();
                        if (yORn == "y")
                        {
                            string ad;
                            string soyad;
                            string tel;
                            Console.WriteLine("***********************************************");
                            Console.Write("Güncel ismi giriniz:");
                            ad = Console.ReadLine();
                            Console.Write("Güncel soyismi giriniz:");
                            soyad = Console.ReadLine();
                            bool kontrol = true;
                            while (kontrol)
                            {
                                Console.Write("Lütfen güncel telefon numarası giriniz  :"); 
                                tel = Console.ReadLine();
                                bool TelefonDogruMu = TelefonFormatKontrol(tel);
                                if (TelefonDogruMu == true)
                                {
                                    item.Isim = ad;
                                    item.Soyisim = soyad;
                                    item.Telno = tel;
                                    kontrol = false;
                                }
                                else
                                {
                                    tel = "";
                                    Console.WriteLine("***********************************************");
                                    Console.WriteLine("Telefon numarası hatalıdır. Lütfen kontrol ediniz. (0xxxxxxxxxx) şeklinde giriniz.");
                                    Console.WriteLine("***********************************************");
                                }
                            }
                            Console.WriteLine("{0} {1} isimli kişi olarak başarıyla güncellendi!.", item.Isim, item.Soyisim);
                            kayitYokise = false;
                            guncelleDongu = false;
                            break;
                        }
                        else if(yORn == "n")
                        {
                            kayitYokise = false;
                            guncelleDongu = false;
                            continue;
                        }
                        else{
                            Console.WriteLine("Yanlış değer girdiniz tekrar deneyin.");
                            kayitYokise = false;
                            guncelleDongu = false;
                            continue;
                        }
                    }
                }
                if (kayitYokise)
                {
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için           : (2)");
                    bool kayitYokiseALT = true;
                    while (kayitYokiseALT)
                    {
                        Console.Write("Seçiminiz <1 - 2> : ");
                        try
                        {
                            guncelleSecim = Convert.ToInt32(Console.ReadLine());
                            switch (guncelleSecim)
                            {
                                case 1:
                                    kayitYokiseALT = false;
                                    guncelleDongu = false;
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
        }

        static void Listele(List<Rehber> kisiler)
        {
            Console.WriteLine("\nTelefon Rehberi");
            Console.WriteLine("*******************************************");
            foreach (var kisi in kisiler)
            {
                Console.WriteLine("İsim              : {0}",kisi.Isim);
                Console.WriteLine("Soyisim           : {0}",kisi.Soyisim);
                Console.WriteLine("Telefon Numarası  : {0}",kisi.Telno);
                Console.WriteLine("-");
            }
        }

        static void RehberdeAra(List<Rehber> kisi)
        {
            Console.WriteLine("\nArama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string adVeyaSoyad;
            string tel;
            int rehberSecimNo;
            bool rehberSecim = true;
            bool kayitVarmi = true;
            while (rehberSecim)
            {
                Console.Write("Seçiminiz <1 - 2> : ");
                try
                {
                    rehberSecimNo = Convert.ToInt32(Console.ReadLine());
                    if (rehberSecimNo == 1)
                    {
                        Console.WriteLine("***********************************************");
                        Console.Write("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz: ");
                        adVeyaSoyad = Console.ReadLine();
                        Console.WriteLine("\nArama Sonuçları");
                        Console.WriteLine("*******************************************");
                        foreach (var item in kisi)
                        {
                            if (item.Isim == adVeyaSoyad || item.Soyisim == adVeyaSoyad)
                            {
                                Console.WriteLine("İsim              : {0}",item.Isim);
                                Console.WriteLine("Soyisim           : {0}",item.Soyisim);
                                Console.WriteLine("Telefon Numarası  : {0}",item.Telno);
                                Console.WriteLine("-");
                                kayitVarmi = false;
                            }
                        }
                        if (kayitVarmi)
                        {
                            Console.WriteLine("Kayıt Bulunamadı");
                        }
                        rehberSecim = false;
                    }
                    else if (rehberSecimNo == 2)
                    {
                        Console.WriteLine("***********************************************");
                        Console.Write("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz: ");
                        tel = Console.ReadLine();
                        Console.WriteLine("\nArama Sonuçları");
                        Console.WriteLine("*******************************************");
                        foreach (var item in kisi)
                        {
                            if (item.Telno == tel)
                            {
                                Console.WriteLine("İsim              : {0}",item.Isim);
                                Console.WriteLine("Soyisim           : {0}",item.Soyisim);
                                Console.WriteLine("Telefon Numarası  : {0}",item.Telno);
                                Console.WriteLine("-");
                                kayitVarmi = false;
                            }
                        }
                        if (kayitVarmi)
                        {
                            Console.WriteLine("Kayıt Bulunamadı");
                        }
                        rehberSecim = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Yanlış bir değer girdiniz. Lütfen 1 veya 2 değerini giriniz. Hata: {0}", e.Message); 
                }
            }
        }

        //Telefon numarası formatı
        public static bool TelefonFormatKontrol(string Telefon)
        {
            string RegexDesen  = @"^(0(\d{10}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }
    }

    class Rehber
    {
        private string isim;
        private string soyisim;
        private string telno;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Telno { get => telno; set => telno = value; }
    }
}
