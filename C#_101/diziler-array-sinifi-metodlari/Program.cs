using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23, 12, 4, 35, 86, 72, 3, 11, 7};

            Console.WriteLine("******* Sırasız Dizi *******");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("******* Sıralı Dizi *******");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
