namespace LeetCode.Problem925{
//925. Long Pressed Name
//https://leetcode.com/problems/long-pressed-name/
/*
Your friend is typing his name into a keyboard. Sometimes, when typing a character c, the key might get long pressed, and the character will be typed 1 or more times.

You examine the typed characters of the keyboard. Return True if it is possible that it was your friends name, with some characters (possibly none) being long pressed.
*/
  public class Solution {
    public bool IsLongPressedName(string name, string typed) {
       Dictionary<int,char> typedDictionary = new();
        Dictionary<int,char> nameDictionary = new();
        for (int i = 0; i < typed.Length; i++)
        {
          typedDictionary.TryAdd(i,typed.ElementAt(i));
        }
        for (int i = 0; i < name.Length; i++)
        {
          nameDictionary.TryAdd(i,name.ElementAt(i));
        }
        Dictionary<int,KeyValuePair<char,int>> maskName = new();
        Dictionary<int,KeyValuePair<char,int>> maskTyped = new();
         
        char elementName = name.ElementAt(0);
        maskName.TryAdd(0,new KeyValuePair<char, int>(elementName,1));
        
        char elementTyped = typed.ElementAt(0);
        maskTyped.TryAdd(0,new KeyValuePair<char, int>(elementTyped,1));

         for (int i = 1; i < typed.Length; i++)
        { 
          var temp = maskTyped.LastOrDefault();
          if (typed.ElementAt(i)==maskTyped.LastOrDefault().Value.Key)
          
          {  var times = temp.Value.Value;
              times++;
              maskTyped.Remove(temp.Key);
              maskTyped.TryAdd(temp.Key, 
              new KeyValuePair<char,int>(typed.ElementAt(i),times));
          }
          else 
          {
            maskTyped.TryAdd(temp.Key+1, 
            new KeyValuePair<char,int>(typed.ElementAt(i),1));
          }
          
        }
        for (int i = 1; i < name.Length; i++)
        { 
          var temp = maskName.LastOrDefault();
          if (name.ElementAt(i)==temp.Value.Key)
          
          {  var times = temp.Value.Value;
              times++;
              maskName.Remove(temp.Key);
              maskName.TryAdd(temp.Key, 
              new KeyValuePair<char,int>(name.ElementAt(i),times));
          }
          else 
          {
            maskName.TryAdd(temp.Key+1, 
            new KeyValuePair<char,int>(name.ElementAt(i),1));
          }
          
        }
        if (maskTyped.Count==maskName.Count)
        {
          for (int i =0;i<maskTyped.Count;i++)
          {
            if (
              maskTyped
                .Where(p=>p.Key==i)
                .Select(p=>p.Value)
                .Select(p=>p.Key)
                .FirstOrDefault()
                !=
              maskName
                .Where(p=>p.Key==i)
                .Select(p=>p.Value)
                .Select(p=>p.Key)
                .FirstOrDefault())
            {
            return false;
            }

            if(
              maskTyped
                .Where(p=>p.Key==i)
                .Select(p=>p.Value)
                .Select(p=>p.Value)
                .FirstOrDefault()
                <
              maskName
                .Where(p=>p.Key==i)
                .Select(p=>p.Value)
                .Select(p=>p.Value)
                .FirstOrDefault())
            {
            return false;
            }
          }
          return true;
        }

        return false;
    }
}
} 