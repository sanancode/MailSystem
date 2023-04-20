using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    internal class Common
    {
        public static bool checkMinAndMax(int min, int max, int value)
        {
            if (min <= value && value <= max) return true;
            return false;
        }

        public static void throwErrRang(int min, int max)
        {
            Console.WriteLine($"\nYou have to choose menu number between {min} and {max}");
            Console.WriteLine("Try again please...");
        }
    }
}
