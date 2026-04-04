public class Solution {
    private List<int> combination = new List<int>();
    private List<List<int>> result = new List<List<int>>();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        Backtrack(nums, target, 0);
        return result;
    }

    private void Backtrack(int[] nums, int remaining, int index) {
        if (remaining == 0) {
            result.Add(new List<int>(combination));
            return;
        }

        if (remaining < 0) {
            return;
        }

        for (int i = index; i < nums.Length; i++) {
            combination.Add(nums[i]);
            Backtrack(nums, remaining - nums[i], i);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
