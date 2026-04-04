public class Solution {
    public int MaxArea(int[] heights) {
            int left = 0;
            int right = heights.Length - 1;
            int result = 0;
            while (left < right) {
                var height = heights[left];
                var secondHeight = heights[right];
                var width = right - left;
                var area = width * Math.Min(height, secondHeight);
                result = Math.Max(result, area);
                
                if (height < secondHeight) left++;
                else right--;
            }

        return result;
    }
}
