public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var list = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            var num = nums[i];
            var left = i + 1;
            var right = nums.Length - 1;

            if (i > 0 && num == nums[i - 1]) continue;

            while (left < right) {
                var sum = nums[left] + nums[right] + nums[i];
                if (sum == 0) {
                    list.Add(new List<int> {
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

        return list;
    }
}