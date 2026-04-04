public class Solution {
    private List<List<int>> result;
    private List<int> combination;

    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = new List<List<int>>();
        combination = new List<int>();
        BackTrack(nums, target, 0);
        return result;
    }

    private void BackTrack(int[] nums, int remaining, int start) {
        if (remaining == 0) {
            result.Add(new List<int>(combination));
            return;
        }

        if (remaining < 0) {
            return;
        }

        for (int i = start; i < nums.Length; i++) {
            combination.Add(nums[i]);
            BackTrack(nums, remaining - nums[i], i);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
