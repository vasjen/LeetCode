namespace LeetCode.Problem1133{
//1133. Largest Unique Number
//https://leetcode.com/problems/largest-unique-number/
/*
Given an integer array nums, return the largest integer that only occurs once. If no integer occurs once, return -1.
*/
  public class Solution {
     public int LargestUniqueNumber(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (dic.ContainsKey(value))
                dic[value]++;
            else
                dic.Add(value,1);
        }
        if (dic.ContainsValue(1))
            ans = dic.Where(p => p.Value == 1).Select(p => p.Key).OrderBy(p => p).LastOrDefault();
        else
            ans = -1;
        return ans;
        
    }   
}
}