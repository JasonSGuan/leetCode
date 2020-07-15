using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode.Easy
{
    public class _1450NumberOfStudentsDoingHomeworkAtAGivenTime
    {
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
