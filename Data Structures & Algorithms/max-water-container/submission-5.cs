public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            int height1 = heights[left];
            int height2 = heights[right];
            int width = right - left;
            int area = width * Math.Min(height1, height2);
            result = Math.Max(result, area);

            if (height1 < height2) {
                left++;
            } else {
                right--;
            }
        }

        return result;
    }
}
