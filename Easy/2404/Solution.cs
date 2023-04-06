namespace LeetCode.Problem2404{
//2404. Most Frequent Even Element
//https://leetcode.com/problems/most-frequent-even-element/
/*
Given an integer array nums, return the most frequent even element.
If there is a tie, return the smallest one. If there is no such element, return -1.
*/
  public class Solution {
    public int MostFrequentEven(int[] nums) {
      var freq = nums
                .GroupBy(p => p)
                .Where(p => p.Key % 2 == 0)
                .ToList().OrderByDescending(p => p.Count());
      foreach (var item in freq)
      {
        System.Console.WriteLine("value: {0} => {1} times", item.Key, item.Count());
      }
      
      if (freq.Count() == 1)
        return freq.FirstOrDefault().Key;
      if (freq.Count() > 1 )
      {
        if (freq.ElementAt(0).Count() == freq.ElementAt(1).Count())
          return freq.Where(p => p.Count() == freq.ElementAt(0).Count()).Min(p => p.Key);
        return freq.FirstOrDefault().Key;
      }
      return -1;
    }
}
} 