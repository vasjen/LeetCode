namespace LeetCode.Problem989{
//989. Add to Array-Form of Integer
//https://leetcode.com/problems/add-to-array-form-of-integer/
/*
The array-form of an integer num is an array representing its digits in left to right order.

  - For example, for num = 1321, the array form is [1,3,2,1].
Given num, the array-form of an integer, and an integer k, return the array-form of the integer num + k.


*/
  public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        int tempK = k;
        int j = 0;
        Queue<int> QueK = new();
        Queue<int> StackNum = new(num.Reverse());
        while (tempK != 0){
          QueK.Enqueue(tempK % 10);
          tempK = tempK / 10;
          j++;
        }
        if (StackNum.Count < QueK.Count){
          while (StackNum.Count != QueK.Count)
              StackNum.Enqueue(0);
        }
        if (StackNum.Count > QueK.Count){
          while (StackNum.Count != QueK.Count)
              QueK.Enqueue(0);
        }
        
       
        Stack<int> Ans = new();
        int pointer = 0;
        int numToAdd = 0;
        while (StackNum.Any())
        {
          
           numToAdd = QueK.Dequeue() + StackNum.Dequeue()+pointer;
           if (numToAdd >=10 ){
            Ans.Push(numToAdd % 10);
            pointer = 1;
           }
           else{
            Ans.Push(numToAdd);
            pointer = 0;
           } 
           
       
        }
        if (pointer == 1)
          Ans.Push(1);
    
        return Ans.ToArray();
  }
}
} 