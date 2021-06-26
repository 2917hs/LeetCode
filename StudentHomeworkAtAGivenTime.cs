using System;

namespace Program450.LeetCode
{
    public class StudentHomeworkAtAGivenTime
    {
        public StudentHomeworkAtAGivenTime()
        {
            int studentCount = 0;
            int[] startTime = {9,8,7,6,5,4,3,2,1};
            int[] endTime = {10,10,10,10,10,10,10,10,10};
            int queryTime = 5;

            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                {
                    studentCount++;
                }
            }
            Console.WriteLine(studentCount);
        }
    }
}