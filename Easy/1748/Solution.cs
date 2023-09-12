 using System.Text;

namespace LeetCode.Problem1748{
//1748. Sum of Unique Elements
//https://leetcode.com/problems/sum-of-unique-elements/
/*
You are given an integer array nums. The unique elements of an array are the elements that appear exactly once 
in the array.

Return the sum of all the unique elements of nums.
*/
  public class Solution {
    public int SumOfUnique(int[] nums) {
        int ans = 0;
        HashSet<int> dic = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>(); 
        for (int i = 0; i < nums.Length; i++)
        {
            if (duplicates.Contains(nums[i]))
                continue;
            
            if (dic.Contains(nums[i]))
            {
                ans -= nums[i];
                dic.Remove(nums[i]);
                duplicates.Add(nums[i]);
            }
            else
            {
                ans += nums[i];
                dic.Add(nums[i]);
            }
        }
        return ans;
    }
}
} 