namespace LeetCode.Problem2129{
//2129. Capitalize the Title
//https://leetcode.com/problems/capitalize-the-title/
/*
You are given a string title consisting of one or more words separated by a single space, where each word consists of English letters. Capitalize the string by changing the capitalization of each word such that:

If the length of the word is 1 or 2 letters, change all letters to lowercase.
Otherwise, change the first letter to uppercase and the remaining letters to lowercase.
Return the capitalized title.
*/
  public class Solution {
    public string CapitalizeTitle(string title) {
        var lower = title
                    .ToLower()
                    .Split(' ')
                    .Select(p=>p.ToCharArray())
                    .ToList();
        string ans = string.Empty;

        foreach (var item in lower)
        {
          if (item.Length > 2)
          item[0] = char.ToUpper(item[0]);
          ans += new string(item)+" ";
          
        }
        ans = ans.TrimEnd(' ');
       
        return ans;     
    }
}
} 