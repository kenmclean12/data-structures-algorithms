public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new();
        int maxArea = 0;

        for (int i = 0; i <= heights.Length; i++) {
            int currHeight = i == heights.Length ? 0 : heights[i];
            while (stack.Count > 0 && currHeight < heights[stack.Peek()]) {
                int prevHeight = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : ((i - stack.Peek()) - 1);
                maxArea = Math.Max(maxArea, prevHeight * width);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}
