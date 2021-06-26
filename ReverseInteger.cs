using System;
namespace Program450.LeetCode
{
    public class ReverseInteger
    {
        public ReverseInteger()
        {
            Console.WriteLine( Reverse());
        }

        static int Reverse()
        {
            Int32 x = -15342;
            Int32 reversed = 0;
            Int32 reminder = 0;
            bool isNegative = false;
            if (x < 0)
            {
                isNegative = true;
                x = -(x);
            }
            try
            {
                while (x > 0)
                {
                    reminder = x % 10;
                    reversed = checked(reversed * 10 + reminder);
                    x /= 10;
                }
                return isNegative ? -(reversed) : reversed;
            }
            catch
            {
                return 0;
            }
        }
    }
}
