public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int maxArea = 0;

       for (int i = 0; i < heights.Length; i++) {
         var area = (right - left) * Math.Min(heights[left], heights[right]);
         maxArea = Math.Max(maxArea, area);
         if (heights[left] < heights[right]) {
            left++;
         } else {
            right--;
         }
       }

       return maxArea;
    }
}
