namespace LeetCode.Medium.Problem1456{
//1456. Maximum Number of Vowels in a Substring of Given Length
//https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
/*
Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.
*/
public class Solution {
     public int MaxVowels(string s, int k) {
        int ans = 0;
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            if (IsViowel(s[i]))
                sum++;
        }
        ans = sum;
        for (int i = k; i < s.Length; i++)
        {   
            if (IsViowel(s[i]))
                sum++;
            if (IsViowel(s[i - k]))
                sum--;

            ans = Math.Max(ans, sum);
        }
        return ans;
    }
    private bool IsViowel(char k)
    {
        if (   
               k == 'a' 
            || k == 'e' 
            || k == 'i'
            || k == 'o' 
            || k == 'u')
            return true;
        return false;
    }
    }
}