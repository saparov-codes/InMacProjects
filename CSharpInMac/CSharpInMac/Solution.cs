using System;
using System.Numerics;

namespace CSharpInMac;

public class Solution
{
    public int[] TwoSum(int[] nums, int target) // 1
    {
        for(var i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] + nums[i+1] == target)
            {
                return new int[] { i, i + 1 };
            }
        }

        return new int[] {};
    }

    public int Search(int[] nums, int target) // 704
    {
        var index = -1;
        for(var i = 0; i < nums.Length; i++)
        {
            if(target == nums[i])
            {
                return i;
            }
        }
        return index;
    }

    public int SearchInsert(int[] nums, int target) // 35
    {
        int res = 0;
        if(nums.Contains(target))
        {
            return Array.IndexOf(nums, target);
        }

        for(var i = 0; i < nums.Length; i++)
        {
            if(target > nums[i])
            {
                res = i +1;
            }
        }

        return res;
    }

    public int SearchInsert1(int[] nums, int target) // GPT 
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return left;
    }


    public int LongestMonotonicSubarray(int[] nums) // 3105
    {
        int size = nums.Length, decrease = 1, increase = 1;
        int maxLength = 1;

        for(var i = 0; i < size - 1; i++)
        {
            if (nums[i] < nums[i+1])
            {
                increase++;
                decrease = 1;
            }
            else if (nums[i] > nums[i+1])
            {
                decrease++;
                increase = 1;
            }
            else
            {
                increase = 1;
                decrease = 1;
            }
            maxLength = Math.Max(maxLength, Math.Max(increase, decrease));
        }

        return maxLength;
    }


    public int[] DailyTemperatures(int[] temperatures) // 739
    {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int idx = stack.Pop();
                res[idx] = i - idx;
            }
            stack.Push(i);
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


