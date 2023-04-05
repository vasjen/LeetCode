namespace LeetCode.Problem507{
//507. Perfect Number
//https://leetcode.com/problems/perfect-number/
/*
A perfect number is a positive integer that is equal to the sum of its positive divisors, 
excluding the number itself. A divisor of an integer x is an integer that can divide x evenly.

Given an integer n, return true if n is a perfect number, otherwise return false.
*/
  public class Solution {
    public bool CheckPerfectNumber(int num) {

        var divs = 0;
        var index = 1;
        while (index < num)
        {
            if (num % index == 0)
                divs += index;
            index++;
        }
        return divs == num ? true : false;
    }
}
public class Alternative {
   public bool CheckPerfectNumber(int num)  {
        var set = new HashSet<int>(){ 6, 28, 496, 8128, 33550336 };

        return set.Contains(num);

    }
}
} 