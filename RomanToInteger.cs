using System;

namespace Program450.LeetCode
{
    public class RomanToInteger
    {
        public RomanToInteger()
        {
            string s = "LVIII";
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int current = GetValue(s[i]);

                if (i + 1 < s.Length)
                {
                    int next = GetValue(s[i + 1]);
                    if (current >= next)
                    {
                        result = result + current;
                    }
                    else
                    {
                        result = result + next - current;
                        i++;
                    }
                }
                else
                {
                    result = result + current;
                    i++;
                }
            }
            Console.WriteLine(result);
        }

        public int GetValue(char c)
        {
            if (c == 'I')
                return 1;
            if (c == 'V')
                return 5;
            if (c == 'X')
                return 10;
            if (c == 'L')
                return 50;
            if (c == 'C')
                return 100;
            if (c == 'D')
                return 500;
            if (c == 'M')
                return 1000;
            return -1;
        }
    }
}