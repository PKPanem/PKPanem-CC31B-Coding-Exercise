using System;
using System.Collections.Generic;

public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        
        for (int i = 0; i < nums.Length; i++)
        {
           
            int complement = target - nums[i];

           
            if (numIndices.ContainsKey(complement))
            {
                return new int[] { numIndices[complement], i };
            }

           
            if (!numIndices.ContainsKey(nums[i]))
            {
                numIndices.Add(nums[i], i);
            }
        }

      
        return new int[0];
    }

   
    public static void Main(string[] args)
    {
        TwoSumSolution solution = new TwoSumSolution();

        while (true)
        {
            Console.WriteLine("Enter the elements of the array separated by spaces:");
            string[] inputNums = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(inputNums, int.Parse);

            Console.WriteLine("Enter the target value:");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] result = solution.TwoSum(nums, target);
            Console.WriteLine("Output: [{0}]", string.Join(", ", result));

            Console.WriteLine("Do you want to continue? (y/n)");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "y")
                break;
        }
    }
}
