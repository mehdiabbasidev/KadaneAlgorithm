using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadaneAlgorithm
{
    class Program
    {
        public static int MaxSubArraySum(int[] nums)
        {
            int maxSoFar = nums[0];
            int maxEndingHere = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }

        public static void Main()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArraySum(nums));       //output: 6
        }
    }
}
