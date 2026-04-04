public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int maxWater = 0;

       while (left < right) {
          int heightLeft = heights[left];
          int heightRight = heights[right];
          int area = Math.Min(heightLeft, heightRight) * (right - left);
          maxWater = Math.Max(maxWater, area);

          if (heightLeft < heightRight) {
             left++;
          } else {
            right--;
          }
       }

       return maxWater;
    }
}
