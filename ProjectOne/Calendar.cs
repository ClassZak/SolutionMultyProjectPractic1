using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace ProjectOne
{
    public class Calendar
    {
        static DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }
        public static void Main(string[] args)
        {
            DateTime now = GetCurrentDate();
            Console.WriteLine($"Today's date is {now.ToShortDateString()}");
            if(args.Length!=0)
            {
                args[0]= $"Today's date is {now.ToShortDateString()}";
                return;
            }
            Console.ReadKey();
        }
    }
}
