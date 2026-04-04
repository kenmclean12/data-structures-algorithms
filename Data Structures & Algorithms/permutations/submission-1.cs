public class Solution {
    private List<List<int>> result = new();
    private List<int> current = new();
    private bool[] used;
    public List<List<int>> Permute(int[] nums) {
        used = new bool[nums.Length];
        Backtrack(nums);
        return result;
    }

    private void Backtrack(int[] nums) {
        if (current.Count == nums.Length) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++) {
            if (used[i]) continue;
            used[i] = true;
            current.Add(nums[i]);
            Backtrack(nums);
            current.RemoveAt(current.Count - 1);
            used[i] = false;
        }
    }
}
