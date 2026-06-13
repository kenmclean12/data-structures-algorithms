public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int maxArea = 0;

       while (left < right) {
          int h = Math.Min(heights[left], heights[right]);
          int w = right - left;
          maxArea = Math.Max(maxArea, h * w);

          if (heights[left] < heights[right]) {
            left++;
          } else {
            right--;
          }
       }

       return maxArea;
    }
}
