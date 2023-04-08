namespace LeetCode.Medium.Problem1004{
//1004. Max Consecutive Ones III
//https://leetcode.com/problems/max-consecutive-ones-iii/
/*
Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.
*/
public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int counter = 0;
        int ans = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                counter++;
            while (counter > k)
            {   
                if (nums[left] == 0)
                {
                    counter--;
                }
                left++;
            }
           ans = Math.Max(ans, right - left + 1); 
        }
        return ans;
        
    }
}
}