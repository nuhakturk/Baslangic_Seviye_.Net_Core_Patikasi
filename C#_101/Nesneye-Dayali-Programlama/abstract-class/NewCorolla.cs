using System;

namespace arayuzler_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
    }
}