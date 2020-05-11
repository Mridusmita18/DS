using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Solution
    {
        public static bool CircularArrayLoop(int[] nums)
        {
            int i = 0;
            int start = 0, end = 0,cyclecount=0;
            for (int z = 0; z <= nums.Length - 1; z++)
            {
                if (nums[z] > 0)
                {
                    start = nums[z];
                    i = z;
                    break;
                }
            }
            for (int j = i; j <= nums.Length - 1;)
            {
                j = j + nums[j];
                if (j <= nums.Length)
                {
                    if (start == nums[j])
                        return false;
                }
                cyclecount++;
                if (j >= nums.Length - 1)
                {
                    if (j == (nums.Length-1))
                    j = j - (nums.Length-1);
                    else
                    j = j - (nums.Length);
                    end = nums[j];
                    break;
                }
            }
            if (end == start && cyclecount>1)
                return true;
            else return false;

        }
    }
}
