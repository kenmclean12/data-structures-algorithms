public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int> stack = new();
        int maxArea = 0;

        for (int i = 0; i <= heights.Length; i++) {
            int height = i == heights.Length ? 0 : heights[i];
            while (stack.Count > 0 && height < heights[stack.Peek()]) {
                int h = heights[stack.Pop()];
                int width = stack.Count == 0 ? i : ((i - stack.Peek()) - 1);
                maxArea = Math.Max(maxArea, h * width);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}
