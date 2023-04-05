namespace LeetCode.Problem2544{
//2544. Alternating Digit Sum
//https://leetcode.com/problems/alternating-digit-sum/
/*
You are given a positive integer n. Each digit of n has a sign according to the following rules:

The most significant digit is assigned a positive sign.
Each other digit has an opposite sign to its adjacent digits.
Return the sum of all digits with their corresponding sign.
*/
  public class Solution {
    
   
  public int AlternateDigitSum(int n) {
       Stack<int> digits = new Stack<int>();
       int flag = 1;
       int sum = 0;
       while (n > 0)
       {  
        digits.Push(n % 10);
          n /= 10;
       }
       while (digits.Count > 0)
       {
        sum += digits.Pop() * flag;
        flag *= -1;
       }
      
        return sum;
    }
  }
} 