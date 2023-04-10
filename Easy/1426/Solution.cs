namespace LeetCode.Problem1426{
//1426. Counting Elements
//https://leetcode.com/problems/counting-elements/
/*
Given an integer array arr, count how many elements x there are, such that x + 1 is also in arr. If there are duplicates in arr, count them separately.
*/
  public class Solution {
    public int CountElements(int[] arr) {
        Dictionary<int,int> dic = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
         dic.Add(i,arr[i]); 
        }
        int counter = 0;
        foreach (var item in dic)
        {
           if (dic.ContainsValue(item.Value + 1))
            counter++;
        }
        return counter;
    }

}
} 