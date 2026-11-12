public class Solution {
    public int LargestRectangleArea(int[] heights) {
       Stack<int> stack = new();
       int result = 0;

       for (int i = 0; i <= heights.Length; i++) {
         int currH = i == heights.Length ? 0 : heights[i];
         while (stack.Count > 0 && currH < heights[stack.Peek()]) {
            int h = heights[stack.Pop()];
            int w = stack.Count == 0 ? i : (i - stack.Peek()) - 1;
            result = Math.Max(result, h * w);
         }
         
         stack.Push(i);
       }

       return result;
    }
}
