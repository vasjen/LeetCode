namespace LeetCode.Problem2248{
//2248. Intersection of Multiple Arrays
//https://leetcode.com/problems/intersection-of-multiple-arrays/
/*
Given a 2D integer array nums where nums[i] is a non-empty array of distinct positive integers, 
return the list of integers that are present in each array of nums sorted in ascending order.

*/
  public class Solution {
    public IList<int> Intersection(int[][] nums) {
      Dictionary<int,int> numbers = new Dictionary<int,int>();
      List<int> ans = new List<int>();
      for (int i = 0; i < nums.Length; i++)
      {
        foreach (var item in nums[i])
        {
          if (numbers.ContainsKey(item))
            numbers[item]++;
          else 
            numbers.Add(item,1);
        }

      }   
      ans = numbers.Where(p => p.Value == nums.Length).Select(p => p.Key).OrderBy(p => p).ToList();
      return ans;
    }
    
}  
} 