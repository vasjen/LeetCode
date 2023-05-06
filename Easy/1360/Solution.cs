namespace LeetCode.Problem1360{
//1360. Number of Days Between Two Dates
//https://leetcode.com/problems/number-of-days-between-two-dates/
/*
Write a program to count the number of days between two dates.

The two dates are given as strings, their format is YYYY-MM-DD as shown in the examples.
*/
  public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        DateTime date1Arr = DateTime.Parse(date1);
        DateTime date2Arr = DateTime.Parse(date2);
        
        return Math.Abs(Convert.ToInt32((date2Arr - date1Arr).Days));
    }

}
}