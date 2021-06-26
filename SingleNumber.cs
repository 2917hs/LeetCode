using System;

namespace Program450.LeetCode
{
    public class SingleNumber
    {
        public SingleNumber()
        {
            int[] nums = { 4, 1, 2, 1, 2 };
            int single = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                single ^= nums[i];
            }
            Console.WriteLine(single);
        }
    }
}