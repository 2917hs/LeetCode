using System;

namespace Program450.LeetCode
{
    public class PalindromeNumber
    {
        public PalindromeNumber()
        {
            int x = -121;
            if (x < 0)
            {
                Console.WriteLine(false);
            }
            else if (x < 10)
            {
                Console.WriteLine(false);
            }

            Int32 input = x;
            Int32 output = 0;
            Int32 reminder = 0;

            while (x > 0)
            {
                reminder = x % 10;
                output = output * 10 + reminder;
                x /= 10;
            }
            Console.WriteLine(input == output);
        }
    }
}