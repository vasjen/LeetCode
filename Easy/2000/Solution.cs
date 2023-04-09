using System.Text;

namespace LeetCode.Problem2000{
//2000. Reverse Prefix of Word  
//https://leetcode.com/problems/reverse-prefix-of-word/
/*
Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at 
the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.

For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). 
The resulting string will be "dcbaefd".
Return the resulting string.
*/
  public class Solution {
    public string ReversePrefix(string word, char ch) {
        int index = word.IndexOf(ch);
        return word.Contains(ch) ? new string (word.Substring(0,index + 1).Reverse().ToArray())+word.Substring(index + 1) : word;
        
    }
}
public class Alternative{
  public string ReversePrefix(string word, char ch) {
    if (!word.Contains(ch))
      return word;
    StringBuilder sb = new StringBuilder();
    int left = 0;
    int right = 0;
    while (right < word.Length - 1 && word[right] != ch)
      right++;
    left = right;
    while (left >= 0)
    {
      sb.Append(word[left]);
      left--;
    }
    right++;
    while (right < word.Length)
    {
      sb.Append(word[right]);
      right++;
    }
    return sb.ToString();
  }

}
} 