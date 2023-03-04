namespace LeetCode.Problem1974{
//1974. Minimum Time to Type Word Using Special Typewriter
//https://leetcode.com/problems/minimum-time-to-type-word-using-special-typewriter/
/*
There is a special typewriter with lowercase English letters 'a' to 'z' arranged in a circle with a pointer. 
A character can only be typed if the pointer is pointing to that character. 
The pointer is initially pointing to the character 'a'.

Each second, you may perform one of the following operations:

 -Move the pointer one character counterclockwise or clockwise.
 -Type the character the pointer is currently on.

Given a string word, return the minimum number of seconds to type out the characters in word.
*/
  public class Solution {
    public int minTimeToType(string word) {
      int counter=0;
      int position=0;
   
      for (int i = 0; i < word.Length; i++)
      {
        int num = word.ElementAt(i)-97;
        int clockwise = Math.Abs(num-position);
        int counterclockwise = 26-(clockwise);
        if (clockwise>counterclockwise){
          counter+=counterclockwise;
        }
        else{
          counter+=clockwise;
        }
        position=num;
      }



      
    return counter+word.Length;
    }
   
}
} 