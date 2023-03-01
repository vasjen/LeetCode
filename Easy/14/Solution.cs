namespace LeetCode.Problem14{
//14. Longest Common Prefix
//https://leetcode.com/problems/longest-common-prefix/
/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
*/
  public class Solution {
    public string LongestCommonPrefix(string[] strs) {
     //  
     //   int index=1;
     //   bool Contains=true;
     //   string begin=string.Empty;
     // 
     //   if (strs!=null && strs.Length>=1){
     //     if (strs[0].Length>=1){
     //   while(Contains){
     //    begin=strs[0].Substring(0,index)?? "";
     //    System.Console.WriteLine(begin);
     //     foreach (var str in strs){
     //       if (!str.StartsWith(begin)){
     //         Contains=false;
     //         return begin=begin.Remove(begin.Length-1);
     //       }
     //     }
     //     index++;
     //     
     //     }
     //   }
     //   }
     //   return begin;
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