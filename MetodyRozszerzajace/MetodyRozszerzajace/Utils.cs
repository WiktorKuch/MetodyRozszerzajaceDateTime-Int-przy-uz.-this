using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyRozszerzajace
{
    public static class Utils
    {

        public static bool IsDateBetween(DateTime date,DateTime from , DateTime to)   //1.data ktora chcemy sprawdzic 
        {
            return date >= from && date <= to;
        }

        public static bool IsBetween(this DateTime date, DateTime from, DateTime to) // slowo kluczone this - aby metoda byla m.rozszerzajaca dla typu datetime
        {
            return date >= from && date <= to;                                     // trzeba wtedy zmienic klase na static
        }

        public static int Squared(this int value)  // metoda rozsz. dla typu int 
        {
            return value * value;
        }


    }
}
