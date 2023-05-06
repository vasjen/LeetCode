namespace LeetCode.Problem225{
//225. Implement Stack using Queues
//https://leetcode.com/problems/implement-stack-using-queues/
/*
Implement a last-in-first-out (LIFO) stack using only two queues. The implemented stack should support all the functions of a normal stack (push, top, pop, and empty).

Implement the MyStack class:

void push(int x) Pushes element x to the top of the stack.
int pop() Removes the element on the top of the stack and returns it.
int top() Returns the element on the top of the stack.
boolean empty() Returns true if the stack is empty, false otherwise.
Notes:

You must use only standard operations of a queue, which means that only push to back, peek/pop from front, 
size and is empty operations are valid.
Depending on your language, the queue may not be supported natively. 
You may simulate a queue using a list or deque (double-ended queue) as long as you use only a queue's standard operations.
*/

// Definition for a binary tree node.
 public class MyStack {

    List<int> customStack = new List<int>();
    int last = 0;
    public MyStack() {
        
    }
    
    public void Push(int x) {
        customStack.Add(x);
        last++;
    }
    
    public int Pop() {
        var val = customStack[last - 1];
        last--;
        customStack.RemoveAt(last);
        return val;
    }
    
    public int Top() {
        return customStack[last - 1];
        
    }
    
    public bool Empty() {
        return customStack.Count == 0 ? true : false;
    }
}
  }
