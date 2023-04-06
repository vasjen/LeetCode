namespace LeetCode.Problem2042{
//2042. Check if Numbers Are Ascending in a Sentence
//https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/
/*
A sentence is a list of tokens separated by a single space with no leading or trailing spaces. 
Every token is either a positive number consisting of digits 0-9 with no leading zeros, or a word consisting of lowercase English letters.

For example, "a puppy has 2 eyes 4 legs" is a sentence with seven tokens: "2" and "4" are numbers and the other 
tokens such as "puppy" are words.
Given a string s representing a sentence, you need to check if all the numbers in s are strictly increasing 
from left to right (i.e., other than the last number, each number is strictly smaller than the number on its right in s).

Return true if so, or false otherwise.
*/
  public class Solution {
   public bool AreNumbersAscending(string s) {
        Queue<string> tokens = new Queue<string>(s.Split(' '));
        Queue<int> digits = new Queue<int>();
        int temp = 0;
        int comparer = 0;
        while (tokens.Count > 0)
        {
          var t = tokens.Dequeue();
          if (int.TryParse(t, out temp))
            digits.Enqueue(temp);
        }
        temp = 0;
        while (digits.Count > 0)
        { 
          temp = digits.Dequeue();
          if (temp <= comparer)
            return false;
          comparer = temp;
        }

        return true;
    }
}
} 