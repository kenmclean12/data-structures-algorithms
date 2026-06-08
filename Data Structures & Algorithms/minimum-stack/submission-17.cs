public class MinStack {
    private Stack<int> minStack;
    private Stack<int> stack;

    public MinStack() {
        minStack = new();
        stack = new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek()) {
            minStack.Push(val);
        }
     }
    
    public void Pop() {
        int val = stack.Pop();
        if (minStack.Count > 0 && minStack.Peek() == val) {
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
