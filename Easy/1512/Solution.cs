namespace LeetCode.Problem1512{
//1512. Number of Good Pairs
//https://leetcode.com/problems/number-of-good-pairs/
/*
Given an array of integers nums, return the number of good pairs.

A pair (i, j) is called good if nums[i] == nums[j] and i < j.

*/
  public class Solution {
   public int NumIdenticalPairs(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (!dic.ContainsKey(value))
                dic.Add(value,0);
            else
            {
                dic[value]++;
                ans += dic[value];
            }
        }
        return ans;
    }
  }
} 