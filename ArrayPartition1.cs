using System;
namespace Program450.LeetCode
{
    public class ArrayPartition1
    {
        public ArrayPartition1()
        {
            Console.WriteLine(PairSum());
        }

        static int PairSum()
        {
            int[] nums = { 6, 2, 6, 5, 1, 2 };
            Array.Sort(nums);
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
