namespace LeetCode.Problem1365{
//1365. How Many Numbers Are Smaller Than the Current Number
//https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
/*
Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. 
That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

Return the answer in an array.
*/
  public class Solution {
   public int[] SmallerNumbersThanCurrent(int[] nums) {
      HashSet<int> numbers = new HashSet<int>(nums);
      Dictionary<int,int> counter = new Dictionary<int,int>();
      foreach (var item in numbers)
          counter.Add(item,nums.Where(p => p < item).Count());
      
      int[] ans = new int[nums.Length];
      for (int i = 0; i < ans.Length; i++)
          ans[i] = counter[nums[i]];
      return ans;
    }

}
}