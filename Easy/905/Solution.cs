namespace LeetCode.Problem905{
//905. Sort Array By Parity
//https://leetcode.com/problems/sort-array-by-parity/
/*
Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.


*/
  public class Solution {
    
   
    public int[] SortArrayByParity(int[] nums) {

        List<int> numsQ = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
          if (nums[i] % 2 ==0)
            numsQ.Insert(0,nums[i]);
          else
            numsQ.Add(nums[i]);
        }
        return numsQ.ToArray();

    }
    }
} 