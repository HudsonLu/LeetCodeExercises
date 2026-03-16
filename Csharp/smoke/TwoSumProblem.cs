using System;
using System.Collections.Generic;

public class TwoSumProblem : ILeetCodeProblem
{
    public string Name
    {
        get { return "Two Sum"; }
    }

    public void Run()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);

        Console.WriteLine("Input: nums = [2, 7, 11, 15], target = 9");
        Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
    }

    private int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
        }

        return new int[] { };
    }
}