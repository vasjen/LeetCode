using System.Globalization;
using System.Text;

namespace LeetCode.Problem1417{
//1417. Reformat The String
//https://leetcode.com/problems/reformat-the-string/
/*
You are given an alphanumeric string s. (Alphanumeric string is a string consisting of lowercase English letters and digits).

You have to find a permutation of the string where no letter is followed by another letter and no digit is followed 
by another digit. That is, no two adjacent characters have the same type.

Return the reformatted string or return an empty string if it is impossible to reformat the string.
*/
  public class Solution {
    public string Reformat(string s) {
   
      var countLetter = s.Where(p => Convert.ToInt32(p) >= 97).Count();
      var countDigit = s.Where(p => Convert.ToInt32(p) < 97).Count();
     if (Math.Abs(countLetter - countDigit) > 1)
        return "";
      else{
      Queue<char> Digits = new Queue<char>(s.Where(p => Convert.ToInt32(p) < 97).Select(p=>p).ToArray());
      Queue<char> Letters = new Queue<char>(s.Where(p => Convert.ToInt32(p) >= 97).Select(p=>p).ToArray());
      String ans = string.Empty;
   
      if (Digits.Count == Letters.Count){
        while (Digits.Count > 0)
          ans = ans + Digits.Dequeue() + Letters.Dequeue();
      }
      else {
        if (Digits.Count < Letters.Count){
          ans= Letters.Dequeue().ToString();
           while (Digits.Count > 0)
             ans = ans + Digits.Dequeue() + Letters.Dequeue();
        }
        else{
          ans = Digits.Dequeue().ToString();
           while (Digits.Count > 0)
             ans = ans + Letters.Dequeue() + Digits.Dequeue();
        }  
      }
      return ans;
      }

      
    }

}
} 