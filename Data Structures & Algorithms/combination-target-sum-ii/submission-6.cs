public class Solution {
    private List<List<int>> result = new();
    private List<int> combination = new();
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        Backtrack(candidates, target, 0);
        return result;
    }

    private void Backtrack(int[] nums, int remaining, int index) {
        if (remaining == 0) {
            result.Add(new List<int>(combination));
        }

        if (remaining < 0) return;

        for (int i = index; i < nums.Length; i++) {
            if (i > index && nums[i] == nums[i - 1]) continue;
            combination.Add(nums[i]);
            Backtrack(nums, remaining - nums[i], i + 1);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
