namespace LeetCode.Problem268{
//268. Missing Number
//https://leetcode.com/problems/missing-number/
/*
Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
*/



 
  public class Solution {
   public int MissingNumber(int[] nums) {
        
        Dictionary<int,int> values = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = nums[i];
            values.Add(value,i);
                
        }
        int ans = 0;
        while (ans <= values.Count)
        {
            if (!values.ContainsKey(ans))
                return ans;
            ans++;
        }
        return -1;
    }
    }
    public class Alternative{
        public int MissingNumber(int[] nums) {
      
        HashSet<int> set = new HashSet<int>(nums);
        for (int i = 0; i <= set.Count; i++)
        {
            if (!set.Contains(i))
                return i;
        }
        return -1;
    }
  }
}
