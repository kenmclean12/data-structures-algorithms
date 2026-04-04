public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        int left = 0;
        int right = heights.Length - 1;

        while (left < right) {
            var heightLeft = heights[left];
            var heightRight = heights[right];
            var width = right - left;
            var area = width * Math.Min(heightLeft, heightRight);

            if (heightLeft < heightRight) {
                left++;
            } else {
                right--;
            }

            result = Math.Max(result, area);
        }

        return result;
    }
}
