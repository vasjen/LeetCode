namespace LeetCode.Problem905{
//905. Sort Array By Parity
//https://leetcode.com/problems/sort-array-by-parity/
/*
Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.


*/
  public class Alternative {
    public int[] SortArrayByParity(int[] nums) {
        int i = 0, j = nums.Length - 1;
        while (i < j) 
        {
            while (i < j && nums[i] % 2 == 0)
              i++;
            while (i < j && nums[j] % 2 !=0)
              j--;
           if (i < j) {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
        return nums;

    }
    
    }
} 