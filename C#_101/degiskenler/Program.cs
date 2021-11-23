using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;     // 1 byte  deger araligi: 0 - 255
            sbyte b = 5;    // 1 byte  deger araligi: -128 - 127

            short c = 5;    // 2 byte  deger araligi: -32768 - 32768
            ushort us = 5;  // 2 byte  deger araligi: 0 - 65365
            
            int i = 2;      // 4 byte
            Int16 i16 = 2;  // 2 byte
            Int32 i32 = 2;  // 4 byte
            Int64 i64 = 2;  // 8 byte

            uint ui = 2;    // 4 byte
            long l = 4;     // 8 byte
            ulong ul = 4;   // 8 byte
            
            //Reel sayılar
            float f = 5;    // 4 byte
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';      // 2 byte
            string str = "Nuh";  //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str = "Nuh Aktürk";
            string ad = "Nuh";
            string soyad = "Aktürk";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolean

            bool bool1 = 10>2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int integer20 = 21;
            string yeniDeger = str20 + integer20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2021

            int integer21 = integer20 + Convert.ToInt32(str20);
            Console.WriteLine(integer21); // Çıktısı 41

            int integer22 = integer20 + int.Parse(str20);
            Console.WriteLine(integer22); // Çıktısı 41

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
