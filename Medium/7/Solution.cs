namespace LeetCode.Medium.Problem7{
//7. Reverse Integer
//https://leetcode.com/problems/reverse-integer/
/*
Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes 
the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
*/
public class Solution {
    public int Reverse(int x) {
        Queue<int> stck = new Queue<int>();
        int ans = 0;
        int tmp = x;
        while (tmp != 0)
        {
            stck.Enqueue(tmp % 10);
            tmp /= 10;
        }
        while (stck.Count > 0)
        {
            int value = stck.Dequeue();
            
            if (value * Math.Pow(10,stck.Count) > int.MaxValue 
            ||  value * Math.Pow(10,stck.Count) < int.MinValue)
                return 0;
            if (value * Math.Pow(10,stck.Count) + ans > int.MaxValue 
            ||  value * Math.Pow(10,stck.Count) + ans < int.MinValue)
                return 0;
            ans += value * (int)Math.Pow(10,stck.Count);
        }
        return ans;
    }
}
}