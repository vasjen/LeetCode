namespace LeetCode.Problem1122{
//1122. Relative Sort Array
//https://leetcode.com/problems/relative-sort-array/
/*
Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.

Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. 
Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.
*/
  public class Solution {
      public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        List<int> ans = new();
        Dictionary<int,int> dic = new Dictionary<int,int>();
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!dic.ContainsKey(arr1[i]))
                    dic.Add(arr1[i],1);
                else
                    dic[arr1[i]]++;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
               // ans.Add(arr2[i]);
                if (dic.ContainsKey(arr2[i]))
                {
                    while (dic[arr2[i]] > 0)
                    {
                        dic[arr2[i]]--;
                        ans.Add(arr2[i]);
                    }
                    dic.Remove(arr2[i]);
                }

            }
            while (dic.Count > 0)
            {
                var val = dic.OrderBy(p => p.Key).FirstOrDefault();
                while (dic[val.Key] > 0)
                {
                    ans.Add(val.Key);
                    dic[val.Key]--;
                }
                dic.Remove(val.Key);
            }
        }
        return ans.ToArray();
    } 
}
}