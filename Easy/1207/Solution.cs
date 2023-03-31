namespace LeetCode.Problem1207{
//1207. Unique Number of Occurrences
//https://leetcode.com/problems/unique-number-of-occurrences/
/*
Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.
*/
  public class Solution {
   public bool UniqueOccurrences(int[] arr) {
       
        return arr.GroupBy(p=>p).Count() == arr.GroupBy(p=>p).GroupBy(p=>p.Count()).Count();
    }

}
}