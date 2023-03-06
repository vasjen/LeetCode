namespace LeetCode.Problem1309{
//1309. Decrypt String from Alphabet to Integer Mapping
//https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
/*
You are given a string s formed by digits and '#'. We want to map s to English lowercase characters as follows:

Characters ('a' to 'i') are represented by ('1' to '9') respectively.
Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.
Return the string formed after mapping.
*/
  public class Solution {
   public string FreqAlphabets(string s) {
    
    Stack<char> StackS = new Stack<char>();
    int i = s.Length-1;
    while (i >= 0){
      var newChar = s.ElementAt(i);
      switch (newChar){

        case '#' : {
          var num = int.Parse((s.ElementAt(i - 2).ToString()+s.ElementAt(i - 1)).ToString());
          
          StackS.Push((char)(num + 96));
          i = i - 3;
          break; 
        }
        default : {
          StackS.Push((char)(int)(newChar + 48));
          i--;
          break;
        }

        
      }

    }
    
   string answer = new string(StackS.ToArray());
        return answer;
        
        
    }

}
}