using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Dojo
{
    public static class ReverseInteger
    {
        public static int Reverse(int num)
        {
            var isNegative = num < 0;

            if (isNegative)
            {
                num *= -1;
            }

            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }

            return isNegative ? result * -1 : result;
        }
    }
}
