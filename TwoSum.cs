using System;
using System.Collections.Generic;

namespace Program450.LeetCode
{
    public class TwoSum
    {
        public TwoSum()
        {
            ArrayMethod();
        }

        static int[] ArrayMethod()
        {
            int[] nums = new int[] { 2, 7, 11, 15 };

            int target = 9;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[2];
        }
    }
}
