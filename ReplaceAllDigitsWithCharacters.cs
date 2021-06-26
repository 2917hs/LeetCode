using System;

namespace Program450.LeetCode
{
    public class ReplaceAllDigitsWithCharacters
    {
        public ReplaceAllDigitsWithCharacters()
        {
            string s = "a1b2c3d4e";
            char[] arr = s.ToCharArray();
            for (int i = 1; i < arr.Length; i += 2)
            {
                arr[i] = (char)(arr[i - 1] + arr[i] - '0');
            }
            Console.WriteLine(new string(arr));
        }
    }
}