using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class MathLogics
    {
        public static int Square(int num)
        {
            return (num * num);
        }

        internal static int Cube(int num)
        {
            //return Square(num) * num;
            //return (int)Math.Pow(num, 3);
            return (num * num * num);
        }

        public static int Reverse(int num)
        {
            int rev = 0;

            while (num!=0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }

            return rev;
        }
        public static bool Pallindrome(int num)
        {
            bool isPallindrome = false;

            int rev = Reverse(num);

            return isPallindrome=(rev==num)?true:false;
        }
    }
}
