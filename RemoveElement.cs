using System;

namespace Program450.LeetCode
{
    public class RemoveElement
    {
        public RemoveElement()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int len = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[len] = nums[i];
                    len++;
                }
            }
            Console.WriteLine(len);
        }
    }
}