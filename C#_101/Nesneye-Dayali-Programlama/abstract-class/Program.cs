using System;

namespace arayuzler_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************INTERFACE*********************");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe());

            Console.WriteLine("**************************************");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());

            Console.WriteLine("**************************************");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci());
            Console.WriteLine(corolla.KacTekerlektenOlusur());
            Console.WriteLine(corolla.StandartRengiNe());

            Console.WriteLine("******************ABSTRACT********************");

            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartRengiNe());

            Console.WriteLine("**************************************");

            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMarkaninAraci());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartRengiNe());
        }
    }
}
