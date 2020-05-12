// 155. 最小栈
/*
设计一个支持 push ，pop ，top 操作，并能在常数时间内检索到最小元素的栈。

push(x) —— 将元素 x 推入栈中。
pop() —— 删除栈顶的元素。
top() —— 获取栈顶元素。
getMin() —— 检索栈中的最小元素。
*/

using System.Collections.Generic;
using System;

public class MinStack {

    /** initialize your data structure here. */
    private Stack<int> minStack = new Stack<int>();
    private Stack<int> normalStack = new Stack<int>();
    public MinStack() {
        minStack.Push(int.MaxValue);
    }
    
    public void Push(int x) { // 每次push保证前一个比后一个大
        this.normalStack.Push(x);
        this.minStack.Push(Math.Min(this.minStack.Peek(), x));
    }
    
    public void Pop() {
        this.normalStack.Pop();
    }
    
    public int Top() {
        this.normalStack.Peek();
    }
    
    public int GetMin() {

    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */