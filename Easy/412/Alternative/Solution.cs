namespace LeetCode.Problem412.Alternative{
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
        for (int i = 1; i <= n; i++)
        {
            if (!(i % 3 == 0 || i % 5 == 0))
                ans.Add(i.ToString());
            else
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    ans.Add("FizzBuzz");
                else
                {
                    ans.Add(i % 3 == 0 ? "Fizz" : "Buzz");
                }
            }
            
        }
        return ans;
    }
}
} 