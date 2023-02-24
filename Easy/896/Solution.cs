namespace LeetCode.Problem896{
//896. Monotonic Array
//https://leetcode.com/problems/monotonic-array/
/*
An array is monotonic if it is either monotone increasing or monotone decreasing.

An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing 
if for all i <= j, nums[i] >= nums[j].

Given an integer array nums, return true if the given array is monotonic, or false otherwise.
*/
  public class Solution {
    
   
   public bool IsMonotonic(int[] nums) {
       
      
      
        if (!Enumerable.SequenceEqual(nums.OrderBy(p=>p).ToArray(),nums) && !Enumerable.SequenceEqual(nums.OrderByDescending(p=>p).ToArray(),nums)){
          return false;
        }
        return true;
    }
    }
  public class Alternative {
    
   
   public bool IsMonotonic(int[] nums) {
       
     
      int num=nums[0];
      int increasing=0;
      int decreasing=0;

        for (int i=1;i<nums.Length;i++){
          if  (num>nums[i]){
              increasing++;
            }
            if (num<nums[i]){
              decreasing++;
            }
            num=nums[i];
        }
        return (decreasing==0 || increasing==0);
    }
    }
} 