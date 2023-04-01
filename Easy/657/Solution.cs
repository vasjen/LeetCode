namespace LeetCode.Problem657{
//657. Robot Return to Origin
//https://leetcode.com/problems/robot-return-to-origin/
/*
There is a robot starting at the position (0, 0), the origin, on a 2D plane. 
Given a sequence of its moves, judge if this robot ends up at (0, 0) after it completes its moves.

You are given a string moves that represents the move sequence of the robot where moves[i] represents its ith move. 
Valid moves are 'R' (right), 'L' (left), 'U' (up), and 'D' (down).

Return true if the robot returns to the origin after it finishes all of its moves, or false otherwise.

Note: The way that the robot is "facing" is irrelevant. 'R' will always make the robot move to the right once, 
'L' will always make it move left, etc. Also, assume that the magnitude of the robot's movement is the same for each move.
*/
  public class Solution {
    public bool JudgeCircle(string moves) {
        var steps = moves
                    .GroupBy(p => p)
                    .ToDictionary(p => p.Key, p => p.Count());
        
       if (steps.Count == 2)
       {
        if (
            (steps.ElementAt(0).Key == 'U' && steps.ElementAt(1).Key == 'D' 
                || steps.ElementAt(1).Key == 'U' && steps.ElementAt(0).Key == 'D')
            ||
            (steps.ElementAt(0).Key == 'L' && steps.ElementAt(1).Key == 'R' 
                || steps.ElementAt(1).Key == 'L' && steps.ElementAt(0).Key == 'R')
            && (steps.ElementAt(0).Value == steps.ElementAt(1).Value)
            )
                return true;
       }
       if (steps.Count == 4)
       {
        if (
            steps['U'] == steps['D'] 
            && 
            steps['L'] == steps['R']
            )
            return true;
            
       }
       
        return false;
    }
}
} 