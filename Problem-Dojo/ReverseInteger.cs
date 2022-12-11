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

            var charArray = num.ToString().ToCharArray();
            var reversed = charArray.Reverse().ToList();

            var sb = new StringBuilder();

            for(int i=0;i< reversed.Count(); i++)
            {
                var c = reversed[i].ToString();
                sb.Append(c);
            }

            var result = sb.ToString();

            if (isNegative)
            {
                result = "-" + result;
            }

            return int.Parse(result);
        }
    }
}
