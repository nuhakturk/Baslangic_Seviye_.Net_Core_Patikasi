using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe());
        }
    }
}
