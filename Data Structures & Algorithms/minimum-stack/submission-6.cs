public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new();
        minStack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || minStack.Peek() >= val) {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        int val = stack.Pop();
        if (val == minStack.Peek()) {
            minStack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
