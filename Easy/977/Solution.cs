
namespace LeetCode.Problem977{
//977. Squares of a Sorted Array
//https://leetcode.com/problems/squares-of-a-sorted-array/description/
/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.



*/
  public class Solution {
    public int[] SortedSquares(int[] nums) {
    Stack<(int, int)> stack = new Stack<(int, int)>();
    stack.Push((0, nums.Length - 1));

    for (int k = 0; k < nums.Length; k++)
        nums[k] *= nums[k];
   
    while (stack.Count > 0)
    {
        (int left, int right) = stack.Pop();
        int i = left, j = right;
        int pivot = nums[(left + right) / 2];

        while (i <= j)
        {
            while (nums[i] < pivot)
                i++;
            while (nums[j] > pivot)
              j--;
            if (i <= j)
            {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++;
                j--;
            }
        }

        if (left < j)
          stack.Push((left, j));

        if (i < right)
          stack.Push((i, right));
    }
      return nums;
      }
      
    }
    
}
