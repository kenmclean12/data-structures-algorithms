public class Solution {
    public int Trap(int[] height) {
       int left = 0;
       int right = height.Length - 1;
       int leftMax = 0;
       int rightMax = 0;
       int maxArea = 0;

       while (left < right) {
         if (height[left] < height[right]) {
            if (height[left] >= leftMax) {
              leftMax = height[left];
            } else {
              maxArea += (leftMax - height[left]);
            }

            left++;
         } else {
            if (height[right] >= rightMax) {
              rightMax = height[right];
            } else {
              maxArea += (rightMax - height[right]);
            }

            right--;
         }
       }

       return maxArea;
    }
}
