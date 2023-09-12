namespace LeetCode.Problem412{
//412. Fizz Buzz
//https://leetcode.com/problems/fizz-buzz/
/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
*/
public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> ans = new();
        string val = String.Empty;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 ^ i % 5 == 0)
                val = i % 3 == 0 ? "Fizz" : "Buzz";
            else
                val = i % 15 == 0 ? "FizzBuzz" : i.ToString();
            ans.Add(val);
        }
        return ans;
    }
}
} 