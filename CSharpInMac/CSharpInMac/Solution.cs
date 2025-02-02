using System;
using System.Numerics;

namespace CSharpInMac;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures) // 739
    {
        var res = new int[temperatures.Length];
        for(var i = 0; i < temperatures.Length; i++)
        {
            var counter = 0;

            for (var j = i; j < temperatures.Length; j++)
            {
                if (temperatures[i] > temperatures[j])
                {
                    counter++;
                }
                else
                {
                    res[i] = counter;
                    break;
                }
            }
        }
        return res;
    }


    public bool Check(int[] nums) // 1768
    {
        var counter = 0;
        int n = nums.Length;

        for (var i = 0; i < n; i++)
        {
            if (nums[i] > nums[(i + 1) % n]) 
            {
                counter++;
            }
        }

        return counter <= 1; 
    }
}


