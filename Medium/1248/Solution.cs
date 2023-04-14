namespace LeetCode.Medium.Problem1248{
//1248. Count Number of Nice Subarrays
//https://leetcode.com/problems/count-number-of-nice-subarrays/
/*
Given an array of integers nums and an integer k. A continuous subarray is called nice if there are k odd numbers on it.

Return the number of nice sub-arrays.
*/
public class Solution {
   public int NumberOfSubarrays(int[] nums, int k) {
     int ans = 0;
     int counter = 0;
     Dictionary<int,int> dic = new Dictionary<int,int>();
     dic.Add(0,1);
     for (int right = 0; right < nums.Length; right++)
     {
        if (nums[right] % 2 == 1) 
            counter++;
        if (dic.ContainsKey(counter - k)) {
               ans += dic[counter - k];
           }
           if (dic.ContainsKey(counter)) {
               dic[counter]++;
           } else {
               dic.Add(counter, 1);
           }
         
         
     }   
     return ans;

    }
}
}