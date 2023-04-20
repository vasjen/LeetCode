namespace LeetCode.Problem1893{
//1893. Check if All the Integers in a Range Are Covered
//https://leetcode.com/problems/check-if-all-the-integers-in-a-range-are-covered/
/*
You are given a 2D integer array ranges and two integers left and right. Each ranges[i] = [starti, endi] 
represents an inclusive interval between starti and endi.

Return true if each integer in the inclusive range [left, right] is covered by at least one interval in ranges. Return false otherwise.

An integer x is covered by an interval ranges[i] = [starti, endi] if starti <= x <= endi.

*/
  public class Solution {
      public bool IsCovered(int[][] ranges, int left, int right) {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < ranges.Length; i++)
        {
            int index = ranges[i][0];
            while (index <= ranges[i][1])
            {
                set.Add(index);
                index++;
            }
        }
        while (left <= right)
        {
            if (!set.Contains(left))
                return false;
            left++;
        }
        return true;
    }
  } 
}