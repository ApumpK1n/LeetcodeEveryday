
// 剑指 Offer 09. 用两个栈实现队列
using System.Collections.Generic;

public class CQueue {

    private Stack<int> stack_in = new Stack<int>();
    private Stack<int> stack_out = new Stack<int>();
    public CQueue() {
    }
    
    public void AppendTail(int value) {
        stack_in.Push(value);
    }
    
    public int DeleteHead() {
        if (stack_out.Count <= 0){
            while(stack_in.Count > 0){
                stack_out.Push(stack_in.Pop());
            }
        }
        if (stack_out.Count > 0){
            return stack_out.Pop();
        }
        return -1;
    }
}

/**
 * Your CQueue object will be instantiated and called as such:
 * CQueue obj = new CQueue();
 * obj.AppendTail(value);
 * int param_2 = obj.DeleteHead();
 */