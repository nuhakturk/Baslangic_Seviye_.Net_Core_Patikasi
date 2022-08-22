using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle ve sayı giriniz.(cümle,sayi): ");
            CumleVeSayi();
        }

        static void CumleVeSayi()
        {
            string cumle, degistirilen;
            int sayi;
            cumle = Console.ReadLine();
            cumle.Trim();
            string[] dizi = cumle.Split(',');
            sayi = Convert.ToInt32(dizi[dizi.Length-1]);
            degistirilen = dizi[0];
            try
            {
                dizi[0] = dizi[0].Remove(sayi,1);
                Console.WriteLine(dizi[0]);
            }
            catch (System.Exception)
            {
                Console.WriteLine(dizi[0]);
            }
        }
    }
}
