namespace LeetCode.Problem344{
//344. Reverse String
//https://leetcode.com/problems/reverse-string/description/
/*
Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.
*/
  public class Solution {
   public void ReverseString(char[] s) {
        int i = 0;
        int j = s.Length - 1;
        
        while (j > i)
        {   
            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;
            i++;
            j--;
        }
    }
}
} 