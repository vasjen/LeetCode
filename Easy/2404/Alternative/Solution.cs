namespace LeetCode.Problem2404.Alternative{
//2404. Most Frequent Even Element
//https://leetcode.com/problems/most-frequent-even-element/
/*
Given an integer array nums, return the most frequent even element.
If there is a tie, return the smallest one. If there is no such element, return -1.
*/
  public class Solution {
    public int MostFrequentEven(int[] nums) {
      Dictionary<int,int> numsDic = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] % 2 == 0)
        {
          if (numsDic.ContainsKey(nums[i]))
            numsDic[nums[i]]++;
        else
            numsDic.Add(nums[i], 1);
            }
      }
      if (numsDic.Count < 1)
        return -1;
      var maxFreq = numsDic.Values.Max();
      for (int i = 0; i < numsDic.Count; i++)
      {
        var key = numsDic.ElementAt(i).Key;
        if (numsDic[key] != maxFreq)
          {
            numsDic.Remove(key);
            i--;
          }
      }
      if (numsDic.Count == 1)
        return numsDic.FirstOrDefault().Key;

      return numsDic.Min(p => p.Key);

    }
}
} 