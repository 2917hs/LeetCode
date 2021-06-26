using System;
namespace Program450.LeetCode
{
    public class LongestCommonPrefix
    {
        public LongestCommonPrefix()
        {
            Console.WriteLine(CommonPrefix());
        }

        static string CommonPrefix()
        {
            string[] strs = { "flower", "flow", "flight" };

            if (strs.Length == 0)
            {
                return string.Empty;
            }
            else if (strs.Length == 1)
            {
                return strs[0];
            }

            Array.Sort(strs);

            int preMinLength = Math.Min(strs[0].Length, strs[strs.Length - 1].Length);

            int patternLength = 0;

            while (patternLength < preMinLength && strs[0][patternLength] == strs[strs.Length - 1][patternLength])
            {
                patternLength++;
            }
            return strs[0].Substring(0, patternLength);
        }
    }
}
