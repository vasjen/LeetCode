namespace LeetCode.Problem14{
//14. Longest Common Prefix
//https://leetcode.com/problems/longest-common-prefix/
/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/
  public class Solution {
    public string LongestCommonPrefix(string[] strs) {
          string common=string.Empty;
        if (strs!=null){
            int index =1;
            int count = strs.OrderBy(p=>p.Length).FirstOrDefault().Count();
            while (index<=count){
             common = strs[0].Remove(index);
            foreach (var str in strs)
            {
              if (!str.StartsWith(common))
                return common=common.Remove(common.Length-1);

            }
            index++;
            }

        }

        return common;
    }

  }
}