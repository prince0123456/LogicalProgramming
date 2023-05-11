using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logicalprogram
{
    public class ReverseNum
    {
        public static void reverseNumber()
        {
            int n, rev = 0, rem;
            Console.WriteLine("enter num");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed Number" + rev);
        }
    }
}
