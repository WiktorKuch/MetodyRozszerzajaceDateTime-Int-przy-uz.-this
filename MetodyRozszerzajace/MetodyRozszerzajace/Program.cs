using System;

namespace MetodyRozszerzajace
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            DateTime before = now.Subtract(new TimeSpan(7,0,0,0));
            DateTime after = now.AddDays(7);

            bool isDateBetween = Utils.IsDateBetween(now,before,after); // metoda sprawdza ze data mieści sie w przedziale 

            bool isDatebetween2 = now.IsBetween(before,after);  // na wartosci typu datetime wywołamy nasza metode - poniewaz klasa jej nie posiada- uzycie extension methods
                                                                // IsBetween(); pierwotnie nie istnieje - jest to nasza metoda rozszerzajaca


            int value = 2;
            value.Squared();



        }
    }
}