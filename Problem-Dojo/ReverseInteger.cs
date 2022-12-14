using System.Text;

namespace Problem_Dojo
{
    public static class ReverseInteger
    {
        public static int Reverse(int num)
        {
            var reversedNumValue = new StringBuilder();

            var numChars = num.ToString().ToCharArray().Select(c => c.ToString()).Where(c => c != "-").ToArray();

            for (var i = numChars.Length - 1; i > -1; i--)
            {
                reversedNumValue.Append(numChars[i]);
            }

            var reversedNum = int.Parse(reversedNumValue.ToString());

            return (num >= 0) ? reversedNum : (-1) * reversedNum;
        }
    }
}
