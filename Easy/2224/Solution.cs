namespace LeetCode.Problem2224{
//2224. Minimum Number of Operations to Convert Time
//https://leetcode.com/problems/minimum-number-of-operations-to-convert-time/
/*
You are given two strings current and correct representing two 24-hour times.

24-hour times are formatted as "HH:MM", where HH is between 00 and 23, and MM is between 00 and 59. 
The earliest 24-hour time is 00:00, and the latest is 23:59.

In one operation you can increase the time current by 1, 5, 15, or 60 minutes. You can perform this operation any number of times.

Return the minimum number of operations needed to convert current to correct.

*/
  public class Solution {
    public int ConvertTime(string current, string correct) {
        var hourCurrent =int.Parse(current.Split(':')[0]);
        var hourCorrect = int.Parse(correct.Split(':')[0]);
        var minCurrent = int.Parse(current.Split(':')[1]);
        var minCorrect = int.Parse(correct.Split(':')[1]);
        var currentTime = hourCurrent * 60 + minCurrent;
        var correctTime = hourCorrect * 60 + minCorrect;
        int steps = 0;
        if (currentTime == correctTime)
        {
          return 0;
        }
        while (currentTime != correctTime)
            {
              switch ((correctTime - currentTime) / 5)
              {
                case >= 12 :
                    steps++;
                    currentTime+=60;
                    break;
                case >= 3 :
                    steps++;
                    currentTime+=15;
                    break;
                case >= 1:
                    steps++;
                    currentTime+=5;
                    break;
                case 0 :
                    steps++;
                    currentTime+=1;
                    break;
                
              }
            }
        
        return steps;
    }
    
}  
} 