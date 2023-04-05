namespace LeetCode.Problem1295{
//1295. Find Numbers with Even Number of Digits
//https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
/*
Given an array nums of integers, return how many of them contain an even number of digits.
*/
  public class Solution {
    public int FindNumbers(int[] nums) {
        int counter = 0;
        int numbers = 0;
        for (int i = 0; i < nums.Length; i++)
        {
          System.Console.Write("For {0}",nums[i]);
          while (nums[i] > 0)
          {
            nums[i] /= 10;
            numbers++;
          }
          if (numbers % 2 == 0)
            counter++;
          numbers = 0;
        }

        return counter;
    }

}
}