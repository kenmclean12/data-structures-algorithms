public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int max = 0;

       while (left < right) {
         int h = Math.Min(heights[left], heights[right]);
         int w = right - left;
         max = Math.Max(max, h * w);

         if (heights[left] < heights[right]) {
           left++;
         } else {
           right--;
         }
       }

       return max;
    }
}
