﻿using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "Dersimiz CSharp";
            string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";
            string degisken4 = "CSharp";
            
            //Lenght;
            Console.WriteLine(degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare , CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(String.Compare(degisken,degisken3, true));
            Console.WriteLine(String.Compare(degisken,degisken3, false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken4));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Nuh"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));
            
            //PadLeft, PadRight
            Console.WriteLine(degisken + degisken4.PadLeft(30));
            Console.WriteLine(degisken + degisken4.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken4);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken4);

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));
            
            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
        }
    }
}
