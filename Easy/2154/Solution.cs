namespace LeetCode.Problem2154{
//2154. Keep Multiplying Found Values by Two
//https://leetcode.com/problems/keep-multiplying-found-values-by-two/
/*
You are given an array of integers nums. You are also given an integer original which is the first number 
that needs to be searched for in nums.

You then do the following steps:

If original is found in nums, multiply it by two (i.e., set original = 2 * original).
Otherwise, stop the process.
Repeat this process with the new number as long as you keep finding the number.
Return the final value of original.
*/
  public class Solution {
   public int FindFinalValue(int[] nums, int original) {
        
        while (nums.Contains(original))
        {
          original *= 2;
        }
        return original;
    }
}
} 