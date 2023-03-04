namespace LeetCode.Problem1422{
//1422. Maximum Score After Splitting a String
//https://leetcode.com/problems/maximum-score-after-splitting-a-string/
/*
Given a string s of zeros and ones, return the maximum score after splitting the string into 
two non-empty substrings (i.e. left substring and right substring).

The score after splitting a string is the number of zeros in the left substring plus the number of ones in the right substring.
*/
  public class Solution {
    public int MaxScore(string s) {
        int num = 0;

        for (int i = 1; i < s.Length; i++)
        {
          var sum = s.Take(i).Where(p=>p == '0').Count()+s.Skip(i).Where(p=>p == '1').Count();
          if (sum > num)
            num = sum;
        }

        return num;
    }

}
} 