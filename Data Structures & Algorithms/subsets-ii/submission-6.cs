public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new();
        HashSet<string> used = new();
        result.Add(new List<int>());

        for (int i = 0; i < nums.Length; i++) {
            int count = result.Count;
            for (int j = 0; j < count; j++) {
                var newList = new List<int>(result[j]);
                newList.Add(nums[i]);
                string key = string.Join(",", newList);
                if (!used.Contains(key)) {
                    result.Add(newList);
                }

                used.Add(key);
            }
        }

        return result;
    }
}
