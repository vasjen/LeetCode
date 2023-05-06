namespace LeetCode.Problem258{
//258. Add Digits
//https://leetcode.com/problems/add-digits/
/*
Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
*/

// Definition for a binary tree node.
 public class Solution {
    public int AddDigits(int num) {
        
       
       if (num < 10)
       return num;
        while (num / 10 > 0)
        {
            int tempNum = num;
            Stack<int> digits = new Stack<int>();
            while (tempNum > 0)
            {
                digits.Push(tempNum % 10);
                tempNum /= 10;
            }
            num = digits.Sum();
        }
        return num;
    }
 }
}
