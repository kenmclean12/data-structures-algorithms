public class MinStack {
    private Stack<int> minStack;
    private Stack<int> stack;

    public MinStack() {
        minStack = new();
        stack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0) {
            minStack.Push(val);
        } else {
            minStack.Push(Math.Min(val, minStack.Peek()));
        }
     }
    
    public void Pop() {
        stack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }   
}
