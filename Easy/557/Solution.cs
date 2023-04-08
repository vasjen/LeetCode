using System.Text;

namespace LeetCode.Problem557{
//557. Reverse Words in a String III
//https://leetcode.com/problems/reverse-words-in-a-string-iii/
/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace 
and initial word order.


*/
  public class Solution {
   public string ReverseWords(string s) {

     string[] words = s.Split(' ');
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
           sb.Append(new string (words[i].Reverse().ToArray()));
           sb.Append(" ");
        }
        sb.Remove(sb.Length -1,1);
        return sb.ToString();
    }



 }
 public class Alternative {
   public string ReverseWords(string s) {

        
        StringBuilder sb = new StringBuilder();
        int left = 0;
        int right = 0;
        
        while (right < s.Length)
        {   
            if (s[right] == ' ')
            {
                int tmp = right;
                while (tmp > left)
                {
                 tmp--;
                 sb.Append(s[tmp]);
                }
                sb.Append(' ');
                left = right + 1;
            }
            if (right == s.Length -1)
            {

               int tmp = right;
                while (tmp >= left)
                {
                 sb.Append(s[tmp]);
                 tmp--;
                }
            }
            right++;
        }
        return sb.ToString();
    }

    

 }

 public class WithStack {
   public string ReverseWords(string s) {

        
        StringBuilder sb = new StringBuilder();
        Stack<char> st = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
                st.Push(s[i]);
            else 
            {
                while (st.Count > 0)
                    sb.Append(st.Pop());
                sb.Append(' ');
            }
        }
        while (st.Count > 0)
                    sb.Append(st.Pop());

        return sb.ToString();
    }

    

 }
} 