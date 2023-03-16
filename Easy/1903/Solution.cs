namespace LeetCode.Problem1903{
//1903. Largest Odd Number in String
//https://leetcode.com/problems/largest-odd-number-in-string/
/*
You are given a string num, representing a large integer. Return the largest-valued odd integer (as a string) that is a non-empty 
substring of num, or an empty string "" if no odd integer exists.
A substring is a contiguous sequence of characters within a string.

*/
  public class Solution {
     
    public string LargestOddNumber(string num) {
      if (Convert.ToInt32(num.LastOrDefault()) % 2 != 0)
        return num;

      var index = num.LastIndexOf(num.Where(p=> Convert.ToInt32(p) % 2 != 0).LastOrDefault());
      if (index == -1)
        return "";
      return num.Remove(index+1);
  
    }
} 
}