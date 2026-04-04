public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            var height1 = heights[left];
            var height2 = heights[right];
            var width = right - left;
            var area = width * Math.Min(height1, height2);
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
