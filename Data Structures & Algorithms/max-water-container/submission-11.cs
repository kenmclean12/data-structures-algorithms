public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            int heightLeft = heights[left];
            int heightRight = heights[right];
            int width = right - left;
            int area = width * Math.Min(heightLeft, heightRight);
            result = Math.Max(result, area);

            if (heightLeft < heightRight) {
                left++;
            } else {
                right--;
            }
        }

        return result;
    }
}
