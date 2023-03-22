namespace LeetCode.Problem2455{
//2455. Average Value of Even Numbers That Are Divisible by Three
//https://leetcode.com/problems/average-value-of-even-numbers-that-are-divisible-by-three/
/*
Given an integer array nums of positive integers, return the average value of all even integers that are divisible by 3.

Note that the average of n elements is the sum of the n elements divided by n and rounded down to the nearest integer.

*/
  public class Solution {
    
   
    public int AverageValue(int[] nums) {
        var  div3 = nums.Where(p => p % 3 == 0).Where(p => (p / 3) % 2 == 0);
        if (div3.Count() == 0)
          return 0;
        
        double aver = div3.Sum() / div3.Count();
        var ans = Math.Round(aver,MidpointRounding.ToEven);
        
        return Convert.ToInt32(ans);

    }
  }
} 