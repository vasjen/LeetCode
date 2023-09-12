namespace LeetCode.Medium.Problem2300{
//2300. Successful Pairs of Spells and Potions
//https://leetcode.com/problems/successful-pairs-of-spells-and-potions/
/*
You are given two positive integer arrays spells and potions, of length n and m respectively, 
where spells[i] represents the strength of the ith spell and potions[j] represents the strength of the jth potion.

You are also given an integer success. A spell and potion pair is considered successful 
if the product of their strengths is at least success.

Return an integer array pairs of length n where pairs[i] is the number of potions that will 
form a successful pair with the ith spell.
*/
public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        int[] ans = new int[spells.Length];
        Array.Sort(potions);
        for (int i = 0; i < ans.Length; i++)
        {
            int count = binSearch(potions, success / (double) spells[i]);
            ans[i] = potions.Length - count;
        }
        return ans;
    }

    public int binSearch (int[] arr, double target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (target > arr[mid])
                left = mid + 1;
            else right = mid - 1;
        }


        return left;
    }
}
}
