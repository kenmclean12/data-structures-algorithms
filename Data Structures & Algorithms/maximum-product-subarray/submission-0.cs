public class Solution {
    public int MaxProduct(int[] nums) {
        int currentMax = nums[0];
        int currentMin = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            int num = nums[i];

            int tempMax = Math.Max(
                num, 
                Math.Max(num * currentMax, num * currentMin
            ));
            int tempMin = Math.Min(
                num, 
                Math.Min(num, Math.Min(num * currentMax, num * currentMin))
            );

            currentMax = tempMax;
            currentMin = tempMin;
    
            result = Math.Max(result, currentMax);
        }

        return result;
    }
}
