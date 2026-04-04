public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var list = new List<List<int>>();

        for (int i = 0; i < nums.Length; i++) {
            int left = i + 1;
            int right = nums.Length - 1;
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }

            while (left < right) {
                var total = nums[left] + nums[right] + nums[i];
                if (total == 0) {
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
                if (total < 0) {
                    left++;
                } else {
                    right--;
                }
            }
        }

        return list;
    }
}