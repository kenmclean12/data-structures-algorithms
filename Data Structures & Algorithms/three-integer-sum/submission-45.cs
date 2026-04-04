public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int left = i + 1;
            int right = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            while (left < right) {
                int sum = nums[left] + nums[right] + nums[i];
                if (sum == 0) {
                    result.Add(new List<int> {
                        nums[left],
                        nums[right],
                        nums[i]
                    });

                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                } else 
                if (sum < 0) {
                    left++;
                } else {
                    right--;
                }
            }
        }

        return result;   
    }
}