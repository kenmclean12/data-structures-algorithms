public class Solution {
    public int MaxArea(int[] heights) {
       int left = 0;
       int right = heights.Length - 1;
       int result = 0;

       while (left < right) {
          int leftHeight = heights[left];
          int rightHeight = heights[right];
          int width = right - left;
          int height = Math.Min(leftHeight, rightHeight);
          result = Math.Max(result, height * width);

          if (leftHeight < rightHeight) {
            left++;
          } else {
            right--;
          }
       }

       return result;
    }
}
