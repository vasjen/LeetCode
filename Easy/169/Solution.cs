namespace LeetCode.Problem169{
//169. Majority Element
//https://leetcode.com/problems/majority-element/
/*
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.


*/

// Definition for a binary tree node.


 
  public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        int ans = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            if (dic.ContainsKey(value))
            {
                dic[value]++;
                if (dic[value] > nums.Length / 2)
                    ans = value;
            }
            else
                dic.Add(value,1);
              if (dic.ContainsKey(value))
            {
                if (dic[value] > nums.Length / 2)
                    ans = value;
            }
            
        }
        return ans;
    }
    }
  }
