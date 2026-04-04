public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int result = 0;

       while (left < right) {
          var area = (right - left) * Math.Min(heights[left], heights[right]);
          result = Math.Max(result, area);
          if (heights[left] < heights[right]) {
            left++;
          } else {
            right--;
          }
       }

       return result;
    }
}
