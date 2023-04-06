 using System.Text;

namespace LeetCode.Problem1700{
//1700. Number of Students Unable to Eat Lunch
//https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/
/*
You are given two integer arrays students and sandwiches where sandwiches[i] is the type of the i​​​​​​th sandwich in the stack 
(i = 0 is the top of the stack) and students[j] is the preference of the j​​​​​​th student in the initial queue (j = 0 
is the front of the queue). Return the number of students that are unable to eat.
*/
  public class Solution {
    
   
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> stud = new Queue<int>(students);
        Stack<int> sand = new Stack<int>(sandwiches.Reverse());
        while (
                stud.Count > 0 
                && 
                !((stud.Contains(0) ^ stud.Contains(1)) 
                  && sand.Peek() != stud.Peek())
              )
        {
          var peolpe = stud.Dequeue();
          var food = sand.Pop();
          if (peolpe != food)
            {
              stud.Enqueue(peolpe);
              sand.Push(food);
            }
         }
         
        return stud.Count;
    }
    
  }
} 