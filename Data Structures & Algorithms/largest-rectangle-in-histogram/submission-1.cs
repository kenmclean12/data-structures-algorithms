public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new();
        int maxArea = 0;

        for (int i = 0; i <= heights.Length; i++) {
           int currentHeight = (i == heights.Length) ? 0 : heights[i];
           while (stack.Count > 0 && currentHeight <= heights[stack.Peek()]) {
               int index = stack.Pop();
               int height = heights[index];
               int width = stack.Count == 0 ? i : (i - stack.Peek() - 1);
               int area = height * width;
               maxArea = Math.Max(maxArea, area);
           }

           stack.Push(i);
        }
        
        return maxArea;
    }
}
