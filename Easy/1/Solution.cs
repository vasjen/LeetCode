namespace LeetCode.Problem1{
//https://leetcode.com/problems/two-sum/
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
}