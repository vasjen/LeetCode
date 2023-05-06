namespace LeetCode.Problem136{
//136. Single Number
//https://leetcode.com/problems/single-number/
/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.


*/
 
  public class Solution {
     public int SingleNumber(int[] nums) {
           Queue<int> numbers = new Queue<int>(nums);
           HashSet<int> removed = new HashSet<int>();
           int ans = 0;
           while (numbers.Count > 0)
           {
               int val = numbers.Dequeue();

               if (!numbers.Contains(val) && !removed.Contains(val))
                   {
                       ans = val;
                       return val;
                   }
               removed.Add(val);
           }
           return ans;
       }
    }
  }
