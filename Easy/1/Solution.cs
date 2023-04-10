namespace LeetCode.Problem1{
//1. Two Sum
//https://leetcode.com/problems/two-sum/
/*
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] Out = new int[2];
        for (int i=0;i<nums.Length;i++)
        {
            int second=target-nums[i];
                 for (int j=i+1;j<nums.Length;j++)
                 {  
                        if (nums[j]==second)
                        {
                            Out[0]=i;
                            Out[1]=j;
                            break;
                        }
                 }
                
        }
            return Out;
    }
}
    public class Alternative {
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int,int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
              int find = target - nums[i];
              if (dic.ContainsKey(find))
                return new int[] {i,dic[find]};

               if (!dic.ContainsKey(value))
                dic.Add(value,i);
              
            }
                return new int[] {-1,-1};
            }  

    }
}